using Kursach1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach1.View
{
    public partial class AuthorizationForm : Form
    {
        public Prisoners MyPrison;


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
                var MyForm = new MainForm(MyPrison);
                MyForm.Show();
                MyForm.FormClosed += MyForm_FormClosed;
                this.Hide();
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


        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
