namespace _4._1
{
    partial class PhoneForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.PhoneText = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Телефон";
            // 
            // PhoneText
            // 
            this.PhoneText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneText.Location = new System.Drawing.Point(129, 81);
            this.PhoneText.Mask = "(999) 000-0000";
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(205, 26);
            this.PhoneText.TabIndex = 14;
            this.PhoneText.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Phone_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Результаты поиска";
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(28, 223);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ReadOnly = true;
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(293, 190);
            this.ResultsTextBox.TabIndex = 19;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(129, 150);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(112, 35);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.label7);
            this.Name = "PhoneForm";
            this.Text = "SearchPhoneForm";
            this.Load += new System.EventHandler(this.SearchPhoneForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox PhoneText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button SearchButton;
    }
}