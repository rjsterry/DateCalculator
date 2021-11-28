namespace DateCalculator
{
    public partial class dateCalculator : Form
    {
        public dateCalculator()
        {
            InitializeComponent();
        }

        private void CopyToClipboard(TextBox textbox)
        {
            if (textbox.TextLength > 0)
            {
                Clipboard.SetText(textbox.Text);
            }
        }

        private void SelectDateText()
        {
            this.BeginInvoke((MethodInvoker)delegate () {
                dateText.SelectAll();
            });
        }

        private void DateCalculator_Load(object sender, EventArgs e)
        {
            dateText.Clear();
            datePlus30Text.Clear();
            datePlus60Text.Clear();
            datePlus90Text.Clear();
            this.SelectDateText();
        }

        private void DatePlus30CopyButton_Click(object sender, EventArgs e)
        {
            CopyToClipboard(datePlus30Text);
        }

        private void DatePlus60CopyButton_Click(object sender, EventArgs e)
        {
            CopyToClipboard(datePlus60Text);
        }

        private void DatePlus90CopyButton_Click(object sender, EventArgs e)
        {
            CopyToClipboard(datePlus90Text);
        }

        private void dateText_Enter(object sender, EventArgs e)
        {
            this.SelectDateText();
        }

        private void DateText_TextChanged(object sender, EventArgs e)
        {
            if (dateText.MaskCompleted)
            {
                if (DateTime.TryParse(dateText.Text, out DateTime validDate))
                {
                    datePlus30Text.Text = validDate.AddDays(30).ToString("MM/dd/yyyy");
                    datePlus60Text.Text = validDate.AddDays(60).ToString("MM/dd/yyyy");
                    datePlus90Text.Text = validDate.AddDays(90).ToString("MM/dd/yyyy");
                }

                this.SelectDateText();
            }
            else
            {
                datePlus30Text.Clear();
                datePlus60Text.Clear();
                datePlus90Text.Clear();
            }
        }

        private void PinCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = pinCheckbox.Checked;
        }
    }
}