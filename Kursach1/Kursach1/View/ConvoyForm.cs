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
    public partial class ConvoyForm : Form
    {
        public Prisoners MyPrison;
        int id;

        public ConvoyForm()
        {
            InitializeComponent();
        }

        public ConvoyForm(Prisoners Prison, int id)
        {
            InitializeComponent();
            this.MyPrison = Prison;
            this.id = id;

            Prisoner p = MyPrison.prisoners.Find(x => x.Id == id);

            PrisonerFullNameLabel.Text = p.SecondName + " " + p.FirstName + " " + p.Patronymic;
            ConvoyFromTextBox.Text = p.Cell.ToString();

            
        }

        private void ConvoyButton_Click(object sender, EventArgs e)
        {
            try
            {
                string cid = ConvoyToTextBox.Text;
                string NumOfConvoyers = ConvoyersNumTextBox.Text;
                string Duration = DurationTextBox.Text;
                MyPrison.Convoy(id, cid, NumOfConvoyers, Duration);
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
