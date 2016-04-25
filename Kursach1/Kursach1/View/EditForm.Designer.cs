namespace Kursach1.View
{
    partial class EditForm: AddForm
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
            this.ConvoyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConvoyButton
            // 
            this.ConvoyButton.Location = new System.Drawing.Point(522, 12);
            this.ConvoyButton.Name = "ConvoyButton";
            this.ConvoyButton.Size = new System.Drawing.Size(91, 37);
            this.ConvoyButton.TabIndex = 0;
            this.ConvoyButton.Text = "Конвой";
            this.ConvoyButton.UseVisualStyleBackColor = true;
            this.ConvoyButton.Click += new System.EventHandler(this.ConvoyButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 512);
            this.Controls.Add(this.ConvoyButton);
            this.Name = "EditForm";
            this.Text = "Редактировать";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConvoyButton;
    }
}