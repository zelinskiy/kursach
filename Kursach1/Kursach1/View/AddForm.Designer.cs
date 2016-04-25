namespace Kursach1.View
{
    partial class AddForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.ArticleBox = new System.Windows.Forms.TextBox();
            this.CellBox = new System.Windows.Forms.TextBox();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.BirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SentenceYearsBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ImprisonedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HierarchyPlaceTextBox = new System.Windows.Forms.TextBox();
            this.SentenceMonthsBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddButton.Location = new System.Drawing.Point(220, 397);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(185, 59);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Сохранить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(96, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(70, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Камера";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Статья";
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(172, 21);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(254, 22);
            this.SecondNameTextBox.TabIndex = 5;
            this.SecondNameTextBox.Text = "Иванов";
            // 
            // ArticleBox
            // 
            this.ArticleBox.Location = new System.Drawing.Point(172, 157);
            this.ArticleBox.Name = "ArticleBox";
            this.ArticleBox.Size = new System.Drawing.Size(254, 22);
            this.ArticleBox.TabIndex = 7;
            this.ArticleBox.Text = "228";
            // 
            // CellBox
            // 
            this.CellBox.Location = new System.Drawing.Point(172, 185);
            this.CellBox.Name = "CellBox";
            this.CellBox.Size = new System.Drawing.Size(254, 22);
            this.CellBox.TabIndex = 8;
            this.CellBox.Text = "-1";
            this.CellBox.TextChanged += new System.EventHandler(this.CellBox_TextChanged);
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(54, 105);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(112, 17);
            this.BirthdayLabel.TabIndex = 9;
            this.BirthdayLabel.Text = "Дата Рождения";
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Location = new System.Drawing.Point(172, 105);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(254, 22);
            this.BirthdayPicker.TabIndex = 10;
            this.BirthdayPicker.Value = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(172, 49);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(254, 22);
            this.FirstNameTextBox.TabIndex = 12;
            this.FirstNameTextBox.Text = "Иван";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Имя";
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(172, 77);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(254, 22);
            this.PatronymicTextBox.TabIndex = 14;
            this.PatronymicTextBox.Text = "Иванович";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Отчество";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SentenceYearsBox
            // 
            this.SentenceYearsBox.Location = new System.Drawing.Point(172, 213);
            this.SentenceYearsBox.Name = "SentenceYearsBox";
            this.SentenceYearsBox.Size = new System.Drawing.Size(56, 22);
            this.SentenceYearsBox.TabIndex = 16;
            this.SentenceYearsBox.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Срок";
            // 
            // ImprisonedDatePicker
            // 
            this.ImprisonedDatePicker.Location = new System.Drawing.Point(172, 238);
            this.ImprisonedDatePicker.Name = "ImprisonedDatePicker";
            this.ImprisonedDatePicker.Size = new System.Drawing.Size(254, 22);
            this.ImprisonedDatePicker.TabIndex = 18;
            this.ImprisonedDatePicker.Value = new System.DateTime(2016, 4, 19, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Заключен под стражу";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Место в иерархии";
            // 
            // HierarchyPlaceTextBox
            // 
            this.HierarchyPlaceTextBox.Location = new System.Drawing.Point(172, 268);
            this.HierarchyPlaceTextBox.Name = "HierarchyPlaceTextBox";
            this.HierarchyPlaceTextBox.Size = new System.Drawing.Size(254, 22);
            this.HierarchyPlaceTextBox.TabIndex = 20;
            this.HierarchyPlaceTextBox.Text = "Мужик";
            // 
            // SentenceMonthsBox
            // 
            this.SentenceMonthsBox.Location = new System.Drawing.Point(287, 210);
            this.SentenceMonthsBox.Name = "SentenceMonthsBox";
            this.SentenceMonthsBox.Size = new System.Drawing.Size(56, 22);
            this.SentenceMonthsBox.TabIndex = 21;
            this.SentenceMonthsBox.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Лет";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Месяцев";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.SecondNameTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SentenceMonthsBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.HierarchyPlaceTextBox);
            this.groupBox1.Controls.Add(this.ArticleBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CellBox);
            this.groupBox1.Controls.Add(this.ImprisonedDatePicker);
            this.groupBox1.Controls.Add(this.BirthdayLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BirthdayPicker);
            this.groupBox1.Controls.Add(this.SentenceYearsBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.FirstNameTextBox);
            this.groupBox1.Controls.Add(this.PatronymicTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(91, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 311);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddButton);
            this.Name = "AddForm";
            this.Text = "Добавление";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox SecondNameTextBox;
        public System.Windows.Forms.TextBox ArticleBox;
        public System.Windows.Forms.TextBox CellBox;
        private System.Windows.Forms.Label BirthdayLabel;
        public System.Windows.Forms.DateTimePicker BirthdayPicker;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox SentenceYearsBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker ImprisonedDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox SentenceMonthsBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox HierarchyPlaceTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}