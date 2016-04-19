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
            this.SuspendLayout();
            // 
            // ShowStatisticsButton
            // 
            this.ShowStatisticsButton.Location = new System.Drawing.Point(1000, 12);
            this.ShowStatisticsButton.Name = "ShowStatisticsButton";
            this.ShowStatisticsButton.Size = new System.Drawing.Size(92, 37);
            this.ShowStatisticsButton.TabIndex = 1;
            this.ShowStatisticsButton.Text = "Stats";
            this.ShowStatisticsButton.UseVisualStyleBackColor = true;
            this.ShowStatisticsButton.Click += new System.EventHandler(this.ShowStatisticsButton_Click);
            // 
            // AddPrisonerButton
            // 
            this.AddPrisonerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddPrisonerButton.Location = new System.Drawing.Point(12, 12);
            this.AddPrisonerButton.Name = "AddPrisonerButton";
            this.AddPrisonerButton.Size = new System.Drawing.Size(81, 54);
            this.AddPrisonerButton.TabIndex = 2;
            this.AddPrisonerButton.Text = "Add Prisoner";
            this.AddPrisonerButton.UseVisualStyleBackColor = false;
            this.AddPrisonerButton.Click += new System.EventHandler(this.AddPrisonerButton_Click);
            // 
            // PrisonersListView
            // 
            this.PrisonersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrisonersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrisonersListView.Location = new System.Drawing.Point(12, 100);
            this.PrisonersListView.Name = "PrisonersListView";
            this.PrisonersListView.Size = new System.Drawing.Size(1080, 514);
            this.PrisonersListView.TabIndex = 3;
            this.PrisonersListView.UseCompatibleStateImageBehavior = false;
            this.PrisonersListView.View = System.Windows.Forms.View.Details;
            this.PrisonersListView.SelectedIndexChanged += new System.EventHandler(this.PrisonersListView_SelectedIndexChanged_1);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Location = new System.Drawing.Point(99, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 54);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchFieldComboBox
            // 
            this.SearchFieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchFieldComboBox.FormattingEnabled = true;
            this.SearchFieldComboBox.Location = new System.Drawing.Point(386, 44);
            this.SearchFieldComboBox.Name = "SearchFieldComboBox";
            this.SearchFieldComboBox.Size = new System.Drawing.Size(233, 24);
            this.SearchFieldComboBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchButton.Location = new System.Drawing.Point(625, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(105, 56);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchTextBox.Location = new System.Drawing.Point(386, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(233, 26);
            this.SearchTextBox.TabIndex = 7;
            // 
            // TestDataButton
            // 
            this.TestDataButton.Location = new System.Drawing.Point(1000, 55);
            this.TestDataButton.Name = "TestDataButton";
            this.TestDataButton.Size = new System.Drawing.Size(92, 39);
            this.TestDataButton.TabIndex = 8;
            this.TestDataButton.Text = "Testdata";
            this.TestDataButton.UseVisualStyleBackColor = true;
            this.TestDataButton.Click += new System.EventHandler(this.TestDataButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(180, 12);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(70, 54);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1104, 626);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.TestDataButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchFieldComboBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PrisonersListView);
            this.Controls.Add(this.AddPrisonerButton);
            this.Controls.Add(this.ShowStatisticsButton);
            this.Name = "MainForm";
            this.Text = "Тюрьма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

