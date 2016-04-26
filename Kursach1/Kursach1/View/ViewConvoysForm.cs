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
    public partial class ViewConvoysForm : Form
    {

        Prisoners MyPrison;

        struct MyRow
        {
            public ProgressBar bar;
            public Label label;
            public Convoy convoy;
        }


        List<MyRow> rows = new List<MyRow>();


        public ViewConvoysForm(Prisoners Prison)
        {
            MyPrison = Prison;
            InitializeComponent();
            foreach(Convoy conv in MyPrison.convoys)
            {
                string message = "Закл. №" + conv.Convoyed.Id.ToString() + ", из " +
                    conv.SourceCell.ToString() + "  в  " + conv.DestinationCell.ToString();
                AddRow(conv,message , conv.DonePart);
            }


            Timer timer = new Timer();
            timer.Tick += RefreshBars;
            timer.Interval = 100;
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshBars(null, null);
        }



        private void RefreshBars(object sender, EventArgs e)
        {
            foreach (MyRow row in rows)
            {
                row.bar.Value = row.convoy.DonePart;
            }
        }



        private void AddRow(Convoy conv, string text, int progress)
        {
            //RowStyle rs = new RowStyle(SizeType.Absolute, 30F);
            RowStyle rs = new RowStyle(SizeType.AutoSize);
            Control con1 = new ProgressBar() { Size = new Size(300, 20), Value = progress };
            Control con2 = new Label() { Text = text, Size = new Size(400, 20) };

            rows.Add(new MyRow() {
                bar = (ProgressBar)con1,
                label = (Label)con2,
                convoy = conv                
            });

            tableLayoutPanel1.RowCount += 1;
            tableLayoutPanel1.RowStyles.Add(rs);
            tableLayoutPanel1.Controls.Add(con2);
            tableLayoutPanel1.Controls.Add(con1);
        }


        

    }
}
