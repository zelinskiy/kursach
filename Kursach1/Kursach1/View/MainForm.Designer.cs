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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ShowStatisticsButton
            // 
            this.ShowStatisticsButton.Location = new System.Drawing.Point(3, 12);
            this.ShowStatisticsButton.Name = "ShowStatisticsButton";
            this.ShowStatisticsButton.Size = new System.Drawing.Size(75, 23);
            this.ShowStatisticsButton.TabIndex = 1;
            this.ShowStatisticsButton.Text = "Stats";
            this.ShowStatisticsButton.UseVisualStyleBackColor = true;
            this.ShowStatisticsButton.Click += new System.EventHandler(this.ShowStatisticsButton_Click);
            // 
            // AddPrisonerButton
            // 
            this.AddPrisonerButton.Location = new System.Drawing.Point(455, 38);
            this.AddPrisonerButton.Name = "AddPrisonerButton";
            this.AddPrisonerButton.Size = new System.Drawing.Size(75, 23);
            this.AddPrisonerButton.TabIndex = 2;
            this.AddPrisonerButton.Text = "Add Prisoner";
            this.AddPrisonerButton.UseVisualStyleBackColor = true;
            this.AddPrisonerButton.Click += new System.EventHandler(this.AddPrisonerButton_Click);
            // 
            // PrisonersListView
            // 
            this.PrisonersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.PrisonersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrisonersListView.Location = new System.Drawing.Point(12, 76);
            this.PrisonersListView.Name = "PrisonersListView";
            this.PrisonersListView.Size = new System.Drawing.Size(749, 367);
            this.PrisonersListView.TabIndex = 3;
            this.PrisonersListView.UseCompatibleStateImageBehavior = false;
            this.PrisonersListView.View = System.Windows.Forms.View.Details;
            this.PrisonersListView.SelectedIndexChanged += new System.EventHandler(this.PrisonersListView_SelectedIndexChanged_1);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(629, 38);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Age";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Article";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cell";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(782, 455);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PrisonersListView);
            this.Controls.Add(this.AddPrisonerButton);
            this.Controls.Add(this.ShowStatisticsButton);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "Тюрьма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ShowStatisticsButton;
        private System.Windows.Forms.Button AddPrisonerButton;
        private System.Windows.Forms.ListView PrisonersListView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

