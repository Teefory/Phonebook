namespace _4._1
{
    partial class SearchAdressForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StreetText = new System.Windows.Forms.TextBox();
            this.HouseText = new System.Windows.Forms.NumericUpDown();
            this.ApartamentText = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.HouseText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApartamentText)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(110, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Результаты поиска";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(43, 295);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ReadOnly = true;
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(293, 190);
            this.ResultsTextBox.TabIndex = 16;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(131, 205);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(112, 35);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Улица";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Дом";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Квартира";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // StreetText
            // 
            this.StreetText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetText.Location = new System.Drawing.Point(205, 35);
            this.StreetText.Name = "StreetText";
            this.StreetText.Size = new System.Drawing.Size(170, 26);
            this.StreetText.TabIndex = 21;
            this.StreetText.TextChanged += new System.EventHandler(this.Street_TextChanged);
            // 
            // HouseText
            // 
            this.HouseText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HouseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseText.Location = new System.Drawing.Point(205, 80);
            this.HouseText.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.HouseText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HouseText.Name = "HouseText";
            this.HouseText.Size = new System.Drawing.Size(170, 26);
            this.HouseText.TabIndex = 22;
            this.HouseText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HouseText.ValueChanged += new System.EventHandler(this.House_ValueChanged);
            // 
            // ApartamentText
            // 
            this.ApartamentText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ApartamentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApartamentText.Location = new System.Drawing.Point(205, 125);
            this.ApartamentText.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ApartamentText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ApartamentText.Name = "ApartamentText";
            this.ApartamentText.Size = new System.Drawing.Size(170, 26);
            this.ApartamentText.TabIndex = 23;
            this.ApartamentText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ApartamentText.ValueChanged += new System.EventHandler(this.Apartament_ValueChanged);
            // 
            // SearchAdressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 515);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StreetText);
            this.Controls.Add(this.HouseText);
            this.Controls.Add(this.ApartamentText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.SearchButton);
            this.Name = "SearchAdressForm";
            this.Text = "SearchAdressForm";
            this.Load += new System.EventHandler(this.SearchAdressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HouseText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApartamentText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StreetText;
        private System.Windows.Forms.NumericUpDown HouseText;
        private System.Windows.Forms.NumericUpDown ApartamentText;
    }
}