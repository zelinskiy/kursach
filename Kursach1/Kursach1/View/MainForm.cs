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
using Kursach1.View;

namespace Kursach1
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Closing(object sender, CancelEventArgs e)
        {
            Prisoners.Save();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

            PrisonersListView.View = System.Windows.Forms.View.Details;
            PrisonersListView.GridLines = true;
            PrisonersListView.FullRowSelect = true;

            
            


            Prisoners.Load();
            RefreshView();

            
            



        }


        public void RefreshView()
        {
            PrisonersListView.Items.Clear();
            foreach (Prisoner p in Prisoners.prisoners)
            {
                PrisonersListView.Items.Add(
                    new ListViewItem(new string[]
                    {
                        p.Id.ToString(),
                        p.Name,
                        p.Age.ToString(),
                        p.Article.ToString(),
                        p.Cell.ToString()
                    }
                    )
                );
            }

            PrisonersListView.Focus();

            PrisonersListView.MultiSelect = false;



        }

        private void PrisonersListView_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PrisonersListView.SelectedItems[0].ToString());
        }



        private void ShowStatisticsButton_Click(object sender, EventArgs e)
        {
            var myForm = new StatsForm();
            myForm.Show();
        }

        private void AddPrisonerButton_Click(object sender, EventArgs e)
        {
            var myForm = new AddForm(this);
            myForm.Show();
        }

        private void PrisonersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(PrisonersListView.SelectedItems[0].ToString());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
            Prisoners.Remove(PrisonersListView.SelectedItems[0].SubItems[0].Text);
            RefreshView();
        }

        private void PrisonersListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
