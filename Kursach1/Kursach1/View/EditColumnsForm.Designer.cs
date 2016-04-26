using System;
using System.Collections.Generic;

namespace Kursach1.View
{
    partial class EditColumnsForm
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
            this.NotSelectedColumnsListBox = new System.Windows.Forms.ListBox();
            this.SelectedColumnsListBox = new System.Windows.Forms.ListBox();
            this.RemoveColumnButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NotSelectedColumnsListBox
            // 
            this.NotSelectedColumnsListBox.FormattingEnabled = true;
            this.NotSelectedColumnsListBox.ItemHeight = 16;
            this.NotSelectedColumnsListBox.Location = new System.Drawing.Point(12, 37);
            this.NotSelectedColumnsListBox.Name = "NotSelectedColumnsListBox";
            this.NotSelectedColumnsListBox.Size = new System.Drawing.Size(161, 340);
            this.NotSelectedColumnsListBox.TabIndex = 0;
            // 
            // SelectedColumnsListBox
            // 
            this.SelectedColumnsListBox.FormattingEnabled = true;
            this.SelectedColumnsListBox.ItemHeight = 16;
            this.SelectedColumnsListBox.Location = new System.Drawing.Point(295, 37);
            this.SelectedColumnsListBox.Name = "SelectedColumnsListBox";
            this.SelectedColumnsListBox.Size = new System.Drawing.Size(164, 340);
            this.SelectedColumnsListBox.TabIndex = 1;
            // 
            // RemoveColumnButton
            // 
            this.RemoveColumnButton.Location = new System.Drawing.Point(197, 156);
            this.RemoveColumnButton.Name = "RemoveColumnButton";
            this.RemoveColumnButton.Size = new System.Drawing.Size(75, 60);
            this.RemoveColumnButton.TabIndex = 3;
            this.RemoveColumnButton.Text = "<--\r\n-->";
            this.RemoveColumnButton.UseVisualStyleBackColor = true;
            this.RemoveColumnButton.Click += new System.EventHandler(this.RemoveColumnButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(197, 335);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 49);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "OK";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исключенные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выбранные";
            // 
            // EditColumnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RemoveColumnButton);
            this.Controls.Add(this.SelectedColumnsListBox);
            this.Controls.Add(this.NotSelectedColumnsListBox);
            this.Name = "EditColumnsForm";
            this.Text = "Изменить колонки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NotSelectedColumnsListBox;
        private System.Windows.Forms.ListBox SelectedColumnsListBox;
        private System.Windows.Forms.Button RemoveColumnButton;
        private Dictionary<string, Func<Prisoner, string>> fields;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}