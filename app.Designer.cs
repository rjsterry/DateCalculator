namespace DateCalculator
{
    partial class dateCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dateCalculator));
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePlus30Label = new System.Windows.Forms.Label();
            this.datePlus60Label = new System.Windows.Forms.Label();
            this.datePlus90Label = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.MaskedTextBox();
            this.datePlus30Text = new System.Windows.Forms.TextBox();
            this.datePlus60Text = new System.Windows.Forms.TextBox();
            this.datePlus90Text = new System.Windows.Forms.TextBox();
            this.pinCheckbox = new System.Windows.Forms.CheckBox();
            this.datePlus30CopyButton = new System.Windows.Forms.Button();
            this.datePlus60CopyButton = new System.Windows.Forms.Button();
            this.datePlus90CopyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(40, 15);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(53, 24);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date:";
            // 
            // datePlus30Label
            // 
            this.datePlus30Label.AutoSize = true;
            this.datePlus30Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePlus30Label.Location = new System.Drawing.Point(12, 50);
            this.datePlus30Label.Name = "datePlus30Label";
            this.datePlus30Label.Size = new System.Drawing.Size(81, 24);
            this.datePlus30Label.TabIndex = 1;
            this.datePlus30Label.Text = "30 Days:";
            // 
            // datePlus60Label
            // 
            this.datePlus60Label.AutoSize = true;
            this.datePlus60Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePlus60Label.Location = new System.Drawing.Point(12, 85);
            this.datePlus60Label.Name = "datePlus60Label";
            this.datePlus60Label.Size = new System.Drawing.Size(81, 24);
            this.datePlus60Label.TabIndex = 2;
            this.datePlus60Label.Text = "60 Days:";
            // 
            // datePlus90Label
            // 
            this.datePlus90Label.AutoSize = true;
            this.datePlus90Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePlus90Label.Location = new System.Drawing.Point(12, 120);
            this.datePlus90Label.Name = "datePlus90Label";
            this.datePlus90Label.Size = new System.Drawing.Size(81, 24);
            this.datePlus90Label.TabIndex = 3;
            this.datePlus90Label.Text = "90 Days:";
            // 
            // dateText
            // 
            this.dateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateText.Location = new System.Drawing.Point(99, 12);
            this.dateText.Mask = "00/00/0000";
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(106, 29);
            this.dateText.TabIndex = 4;
            this.dateText.ValidatingType = typeof(System.DateTime);
            this.dateText.TextChanged += new System.EventHandler(this.DateText_TextChanged);
            this.dateText.Enter += new System.EventHandler(this.dateText_Enter);
            // 
            // datePlus30Text
            // 
            this.datePlus30Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePlus30Text.Location = new System.Drawing.Point(99, 47);
            this.datePlus30Text.Name = "datePlus30Text";
            this.datePlus30Text.ReadOnly = true;
            this.datePlus30Text.Size = new System.Drawing.Size(106, 29);
            this.datePlus30Text.TabIndex = 5;
            this.datePlus30Text.TabStop = false;
            // 
            // datePlus60Text
            // 
            this.datePlus60Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePlus60Text.Location = new System.Drawing.Point(99, 82);
            this.datePlus60Text.Name = "datePlus60Text";
            this.datePlus60Text.ReadOnly = true;
            this.datePlus60Text.Size = new System.Drawing.Size(106, 29);
            this.datePlus60Text.TabIndex = 6;
            this.datePlus60Text.TabStop = false;
            // 
            // datePlus90Text
            // 
            this.datePlus90Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePlus90Text.Location = new System.Drawing.Point(99, 117);
            this.datePlus90Text.Name = "datePlus90Text";
            this.datePlus90Text.ReadOnly = true;
            this.datePlus90Text.Size = new System.Drawing.Size(106, 29);
            this.datePlus90Text.TabIndex = 7;
            this.datePlus90Text.TabStop = false;
            // 
            // pinCheckbox
            // 
            this.pinCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.pinCheckbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pinCheckbox.BackgroundImage")));
            this.pinCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pinCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pinCheckbox.Location = new System.Drawing.Point(211, 12);
            this.pinCheckbox.Name = "pinCheckbox";
            this.pinCheckbox.Size = new System.Drawing.Size(29, 29);
            this.pinCheckbox.TabIndex = 8;
            this.pinCheckbox.TabStop = false;
            this.pinCheckbox.UseVisualStyleBackColor = true;
            this.pinCheckbox.CheckedChanged += new System.EventHandler(this.PinCheckbox_CheckedChanged);
            // 
            // datePlus30CopyButton
            // 
            this.datePlus30CopyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("datePlus30CopyButton.BackgroundImage")));
            this.datePlus30CopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.datePlus30CopyButton.Location = new System.Drawing.Point(211, 47);
            this.datePlus30CopyButton.Name = "datePlus30CopyButton";
            this.datePlus30CopyButton.Size = new System.Drawing.Size(29, 29);
            this.datePlus30CopyButton.TabIndex = 9;
            this.datePlus30CopyButton.UseVisualStyleBackColor = true;
            this.datePlus30CopyButton.Click += new System.EventHandler(this.DatePlus30CopyButton_Click);
            // 
            // datePlus60CopyButton
            // 
            this.datePlus60CopyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("datePlus60CopyButton.BackgroundImage")));
            this.datePlus60CopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.datePlus60CopyButton.Location = new System.Drawing.Point(211, 82);
            this.datePlus60CopyButton.Name = "datePlus60CopyButton";
            this.datePlus60CopyButton.Size = new System.Drawing.Size(29, 29);
            this.datePlus60CopyButton.TabIndex = 10;
            this.datePlus60CopyButton.UseVisualStyleBackColor = true;
            this.datePlus60CopyButton.Click += new System.EventHandler(this.DatePlus60CopyButton_Click);
            // 
            // datePlus90CopyButton
            // 
            this.datePlus90CopyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("datePlus90CopyButton.BackgroundImage")));
            this.datePlus90CopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.datePlus90CopyButton.Location = new System.Drawing.Point(211, 117);
            this.datePlus90CopyButton.Name = "datePlus90CopyButton";
            this.datePlus90CopyButton.Size = new System.Drawing.Size(29, 29);
            this.datePlus90CopyButton.TabIndex = 11;
            this.datePlus90CopyButton.UseVisualStyleBackColor = true;
            this.datePlus90CopyButton.Click += new System.EventHandler(this.DatePlus90CopyButton_Click);
            // 
            // dateCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 162);
            this.Controls.Add(this.datePlus90CopyButton);
            this.Controls.Add(this.datePlus60CopyButton);
            this.Controls.Add(this.datePlus30CopyButton);
            this.Controls.Add(this.pinCheckbox);
            this.Controls.Add(this.datePlus90Text);
            this.Controls.Add(this.datePlus60Text);
            this.Controls.Add(this.datePlus30Text);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.datePlus90Label);
            this.Controls.Add(this.datePlus60Label);
            this.Controls.Add(this.datePlus30Label);
            this.Controls.Add(this.dateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "dateCalculator";
            this.Text = "Date Calculator";
            this.Load += new System.EventHandler(this.DateCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label dateLabel;
        private Label datePlus30Label;
        private Label datePlus60Label;
        private Label datePlus90Label;
        private MaskedTextBox dateText;
        private TextBox datePlus30Text;
        private TextBox datePlus60Text;
        private TextBox datePlus90Text;
        private CheckBox pinCheckbox;
        private Button datePlus30CopyButton;
        private Button datePlus60CopyButton;
        private Button datePlus90CopyButton;
    }
}