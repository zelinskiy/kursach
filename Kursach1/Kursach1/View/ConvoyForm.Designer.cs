namespace Kursach1.View
{
    partial class ConvoyForm
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
            this.PrisonerFullNameLabel = new System.Windows.Forms.Label();
            this.ConvoyButton = new System.Windows.Forms.Button();
            this.ConvoyFromTextBox = new System.Windows.Forms.TextBox();
            this.ConvoyToTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConvoyersNumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PrisonerFullNameLabel
            // 
            this.PrisonerFullNameLabel.AutoSize = true;
            this.PrisonerFullNameLabel.Location = new System.Drawing.Point(116, 46);
            this.PrisonerFullNameLabel.Name = "PrisonerFullNameLabel";
            this.PrisonerFullNameLabel.Size = new System.Drawing.Size(155, 17);
            this.PrisonerFullNameLabel.TabIndex = 0;
            this.PrisonerFullNameLabel.Text = "PrisonerFullNameLabel";
            // 
            // ConvoyButton
            // 
            this.ConvoyButton.Location = new System.Drawing.Point(119, 436);
            this.ConvoyButton.Name = "ConvoyButton";
            this.ConvoyButton.Size = new System.Drawing.Size(164, 39);
            this.ConvoyButton.TabIndex = 1;
            this.ConvoyButton.Text = "Конвоировать";
            this.ConvoyButton.UseVisualStyleBackColor = true;
            this.ConvoyButton.Click += new System.EventHandler(this.ConvoyButton_Click);
            // 
            // ConvoyFromTextBox
            // 
            this.ConvoyFromTextBox.Enabled = false;
            this.ConvoyFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ConvoyFromTextBox.Location = new System.Drawing.Point(44, 166);
            this.ConvoyFromTextBox.Name = "ConvoyFromTextBox";
            this.ConvoyFromTextBox.Size = new System.Drawing.Size(124, 36);
            this.ConvoyFromTextBox.TabIndex = 2;
            this.ConvoyFromTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConvoyToTextBox
            // 
            this.ConvoyToTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ConvoyToTextBox.Location = new System.Drawing.Point(228, 166);
            this.ConvoyToTextBox.Name = "ConvoyToTextBox";
            this.ConvoyToTextBox.Size = new System.Drawing.Size(124, 36);
            this.ConvoyToTextBox.TabIndex = 3;
            this.ConvoyToTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Из камеры №:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "В камеру №:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Конвоиров:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConvoyersNumTextBox
            // 
            this.ConvoyersNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ConvoyersNumTextBox.Location = new System.Drawing.Point(44, 261);
            this.ConvoyersNumTextBox.Name = "ConvoyersNumTextBox";
            this.ConvoyersNumTextBox.Size = new System.Drawing.Size(124, 36);
            this.ConvoyersNumTextBox.TabIndex = 6;
            this.ConvoyersNumTextBox.Text = "2";
            this.ConvoyersNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Приблизит. время (мин)";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DurationTextBox.Location = new System.Drawing.Point(228, 261);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(124, 36);
            this.DurationTextBox.TabIndex = 8;
            this.DurationTextBox.Text = "10";
            this.DurationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConvoyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConvoyersNumTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvoyToTextBox);
            this.Controls.Add(this.ConvoyFromTextBox);
            this.Controls.Add(this.ConvoyButton);
            this.Controls.Add(this.PrisonerFullNameLabel);
            this.Name = "ConvoyForm";
            this.Text = "ConvoyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrisonerFullNameLabel;
        private System.Windows.Forms.Button ConvoyButton;
        private System.Windows.Forms.TextBox ConvoyFromTextBox;
        private System.Windows.Forms.TextBox ConvoyToTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConvoyersNumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DurationTextBox;
    }
}