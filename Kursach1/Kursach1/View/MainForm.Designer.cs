namespace Kursach1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowStatisticsButton = new System.Windows.Forms.Button();
            this.AddPrisonerButton = new System.Windows.Forms.Button();
            this.PrisonersListView = new System.Windows.Forms.ListView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchFieldComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TestDataButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.IsStrictCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ConvoyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowStatisticsButton
            // 
            this.ShowStatisticsButton.Location = new System.Drawing.Point(6, 21);
            this.ShowStatisticsButton.Name = "ShowStatisticsButton";
            this.ShowStatisticsButton.Size = new System.Drawing.Size(92, 37);
            this.ShowStatisticsButton.TabIndex = 1;
            this.ShowStatisticsButton.Text = "Статистика";
            this.ShowStatisticsButton.UseVisualStyleBackColor = true;
            this.ShowStatisticsButton.Click += new System.EventHandler(this.ShowStatisticsButton_Click);
            // 
            // AddPrisonerButton
            // 
            this.AddPrisonerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddPrisonerButton.Location = new System.Drawing.Point(0, 8);
            this.AddPrisonerButton.Name = "AddPrisonerButton";
            this.AddPrisonerButton.Size = new System.Drawing.Size(81, 54);
            this.AddPrisonerButton.TabIndex = 2;
            this.AddPrisonerButton.Text = "Добавить";
            this.AddPrisonerButton.UseVisualStyleBackColor = false;
            this.AddPrisonerButton.Click += new System.EventHandler(this.AddPrisonerButton_Click);
            // 
            // PrisonersListView
            // 
            this.PrisonersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrisonersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrisonersListView.Location = new System.Drawing.Point(12, 210);
            this.PrisonersListView.Name = "PrisonersListView";
            this.PrisonersListView.Size = new System.Drawing.Size(1176, 433);
            this.PrisonersListView.TabIndex = 3;
            this.PrisonersListView.UseCompatibleStateImageBehavior = false;
            this.PrisonersListView.View = System.Windows.Forms.View.Details;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Location = new System.Drawing.Point(87, 8);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 54);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchFieldComboBox
            // 
            this.SearchFieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchFieldComboBox.FormattingEnabled = true;
            this.SearchFieldComboBox.Location = new System.Drawing.Point(146, 45);
            this.SearchFieldComboBox.Name = "SearchFieldComboBox";
            this.SearchFieldComboBox.Size = new System.Drawing.Size(167, 24);
            this.SearchFieldComboBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchButton.Location = new System.Drawing.Point(319, 13);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(105, 56);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchTextBox.Location = new System.Drawing.Point(6, 13);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(307, 26);
            this.SearchTextBox.TabIndex = 7;
            // 
            // TestDataButton
            // 
            this.TestDataButton.Location = new System.Drawing.Point(6, 64);
            this.TestDataButton.Name = "TestDataButton";
            this.TestDataButton.Size = new System.Drawing.Size(92, 39);
            this.TestDataButton.TabIndex = 8;
            this.TestDataButton.Text = "Тест";
            this.TestDataButton.UseVisualStyleBackColor = true;
            this.TestDataButton.Click += new System.EventHandler(this.TestDataButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(168, 8);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(81, 54);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // IsStrictCheckBox
            // 
            this.IsStrictCheckBox.AutoSize = true;
            this.IsStrictCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.IsStrictCheckBox.Location = new System.Drawing.Point(6, 50);
            this.IsStrictCheckBox.Name = "IsStrictCheckBox";
            this.IsStrictCheckBox.Size = new System.Drawing.Size(131, 19);
            this.IsStrictCheckBox.TabIndex = 10;
            this.IsStrictCheckBox.Text = "точн. совпадение";
            this.IsStrictCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "F12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(112, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Del";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(190, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "F11";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ConvoyButton);
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddPrisonerButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 85);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Controls.Add(this.SearchFieldComboBox);
            this.groupBox2.Controls.Add(this.IsStrictCheckBox);
            this.groupBox2.Controls.Add(this.SearchTextBox);
            this.groupBox2.Location = new System.Drawing.Point(479, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 85);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.TestDataButton);
            this.groupBox3.Controls.Add(this.ShowStatisticsButton);
            this.groupBox3.Location = new System.Drawing.Point(1083, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 170);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConvoyButton
            // 
            this.ConvoyButton.Location = new System.Drawing.Point(255, 8);
            this.ConvoyButton.Name = "ConvoyButton";
            this.ConvoyButton.Size = new System.Drawing.Size(81, 54);
            this.ConvoyButton.TabIndex = 14;
            this.ConvoyButton.Text = "Конвой";
            this.ConvoyButton.UseVisualStyleBackColor = true;
            this.ConvoyButton.Click += new System.EventHandler(this.ConvoyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(278, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "F10";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 655);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PrisonersListView);
            this.MinimumSize = new System.Drawing.Size(900, 0);
            this.Name = "MainForm";
            this.Text = "Тюрьма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ShowStatisticsButton;
        private System.Windows.Forms.Button AddPrisonerButton;
        private System.Windows.Forms.ListView PrisonersListView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox SearchFieldComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button TestDataButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.CheckBox IsStrictCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConvoyButton;
    }
}

