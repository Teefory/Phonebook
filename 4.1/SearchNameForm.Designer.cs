namespace _4._1
{
    partial class SearchNameForm
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
            this.LastName1 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.Patronymic1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastName1
            // 
            this.LastName1.AutoSize = true;
            this.LastName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName1.Location = new System.Drawing.Point(62, 31);
            this.LastName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastName1.Name = "LastName1";
            this.LastName1.Size = new System.Drawing.Size(81, 20);
            this.LastName1.TabIndex = 0;
            this.LastName1.Text = "Фамилия";
            this.LastName1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name1.Location = new System.Drawing.Point(62, 88);
            this.Name1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(40, 20);
            this.Name1.TabIndex = 1;
            this.Name1.Text = "Имя";
            this.Name1.Click += new System.EventHandler(this.label2_Click);
            // 
            // Patronymic1
            // 
            this.Patronymic1.AutoSize = true;
            this.Patronymic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patronymic1.Location = new System.Drawing.Point(60, 142);
            this.Patronymic1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Patronymic1.Name = "Patronymic1";
            this.Patronymic1.Size = new System.Drawing.Size(83, 20);
            this.Patronymic1.TabIndex = 2;
            this.Patronymic1.Text = "Отчество";
            this.Patronymic1.Click += new System.EventHandler(this.label3_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(188, 88);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(148, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(188, 142);
            this.PatronymicTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatronymicTextBox.Multiline = true;
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(148, 20);
            this.PatronymicTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(188, 31);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastNameTextBox.Multiline = true;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.LastNameTextBox.TabIndex = 0;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(131, 201);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(112, 35);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(43, 291);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ReadOnly = true;
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(293, 190);
            this.ResultsTextBox.TabIndex = 7;
            this.ResultsTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Результаты поиска";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // SearchNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Patronymic1);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.LastName1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск абонента";
            this.Load += new System.EventHandler(this.SearchNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastName1;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Patronymic1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Label label1;
    }
}