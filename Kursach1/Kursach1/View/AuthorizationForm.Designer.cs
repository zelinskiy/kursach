namespace Kursach1.View
{
    partial class AuthorizationForm
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
            this.components = new System.ComponentModel.Container();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.COMConnectButton = new System.Windows.Forms.Button();
            this.COMportBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(172, 141);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 40);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Вход";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LoginBox.Location = new System.Drawing.Point(133, 34);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(176, 26);
            this.LoginBox.TabIndex = 1;
            this.LoginBox.Text = "1";
            this.LoginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PasswordBox.Location = new System.Drawing.Point(133, 74);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(176, 26);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.Text = "1";
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // COMConnectButton
            // 
            this.COMConnectButton.Location = new System.Drawing.Point(87, 157);
            this.COMConnectButton.Name = "COMConnectButton";
            this.COMConnectButton.Size = new System.Drawing.Size(23, 24);
            this.COMConnectButton.TabIndex = 5;
            this.COMConnectButton.UseVisualStyleBackColor = true;
            this.COMConnectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // COMportBox
            // 
            this.COMportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.COMportBox.Location = new System.Drawing.Point(57, 156);
            this.COMportBox.Name = "COMportBox";
            this.COMportBox.Size = new System.Drawing.Size(24, 24);
            this.COMportBox.TabIndex = 6;
            this.COMportBox.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "RFID";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 205);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.COMportBox);
            this.Controls.Add(this.COMConnectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.LoginButton);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button COMConnectButton;
        public System.Windows.Forms.TextBox COMportBox;
        private System.Windows.Forms.Label label3;
    }
}