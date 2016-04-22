using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach1.Model;

namespace Kursach1.View
{
    public partial class StatsForm : Form
    {
        public Prisoners MyPrison;

        public StatsForm(MainForm parent)
        {
            MyPrison = parent.MyPrison;
            InitializeComponent();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            StatsLabel.Text = MyPrison.FormStatistics();
        }

        private void StatsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
