using Kursach1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach1.View
{
    public partial class AuthorizationForm : Form
    {
        public Prisoners MyPrison;
        public bool Handled = false;

        public List<Tuple<string, string>> passes = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("1", "1"),
            new Tuple<string, string>("2", "2"),
        };

        public AuthorizationForm(Prisoners MyPrison)
        {
            this.MyPrison = MyPrison;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(Auth(LoginBox.Text, PasswordBox.Text))
            {
                LoadMainForm();
            }
            else if(LoginButton.BackColor == Color.Green)
            {
                LoadMainForm();                
            }
            else
            {
                MessageBox.Show("Неправильные логин / пароль");
            }
        }


        private bool Auth(string login, string pass)
        {
            foreach(Tuple<string, string> data in passes)
            {
                if(data.Item1 == login && data.Item2 == pass)
                {
                    return true;
                }
            }
            return false;
        }



        private void LoadMainForm()
        {
            var MyForm = new MainForm(MyPrison);
            MyForm.Show();
            MyForm.FormClosed += MyForm_FormClosed;            
            this.Hide();
        }

        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = "COM" + COMportBox.Text;
                    serialPort1.Open();
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(RFIDAuthorizedHandler);
                    serialPort1.ReadTimeout = 100;
                    COMConnectButton.BackColor = Color.Green;
                }
                catch
                {
                    MessageBox.Show("Не удалось подключиться");
                }
            }
        }

        private void RFIDAuthorizedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            if(indata.Contains("1"))
            {
                sp.Close();
                LoginButton.BackColor = Color.Green;
            }
             
        }


    }
}
