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

            PrisonersListView.KeyDown += new KeyEventHandler(PrisonersListView_KeyPress);

            string[] cols = new string[]
            {
                "Номер",
                "Фамилия",
                "Возраст",
                "Статья",
                "Камера",
                "Ост. дней",
                "Иерархич."
            };


            for(int i=0; i< cols.Length; i++)
            {
                PrisonersListView.Columns.Add(cols[i],150);
                SearchFieldComboBox.Items.Add(cols[i]);
            }


            PrisonersListView.ColumnClick += new ColumnClickEventHandler(ColumnClick);
            SearchFieldComboBox.SelectedIndex = 0;

            Prisoners.Load();
            RefreshView(Prisoners.prisoners);

            

        }


        void PrisonersListView_KeyPress(object sender,KeyEventArgs e)
        {
            //MessageBox.Show("Form.KeyPress: '" + e.KeyCode.ToString() + "' pressed.");
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    DeleteButton_Click(null, null);
                    break;
                case Keys.E:
                    EditButton_Click(null, null);
                    break;

            }
        }
        



        public void RefreshView(List<Prisoner> ps)
        {
            PrisonersListView.Items.Clear();
            foreach (Prisoner p in ps)
            {
                PrisonersListView.Items.Add(
                    new ListViewItem(new string[]
                    {
                        p.Id.ToString(),
                        p.SecondName,
                        p.Age.ToString(),
                        p.Article.ToString(),
                        p.Cell.ToString(),
                        p.SentenceDaysLeft.ToString(),
                        p.Hierarchy
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
            if (PrisonersListView.SelectedItems.Count == 1)
            {
                Prisoners.Remove(PrisonersListView.SelectedItems[0].SubItems[0].Text);
                RefreshView(Prisoners.prisoners);
            }
            
        }

        private void PrisonersListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }



        

        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            RefreshView(Prisoners.OrderBy(e.Column.ToString()));
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            RefreshView(Prisoners.SearchBy(SearchFieldComboBox.SelectedIndex.ToString(), SearchTextBox.Text));
            
        }

        private void TestDataButton_Click(object sender, EventArgs e)
        {
            Prisoners.Create();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PrisonersListView.SelectedItems.Count == 1)
            {
                var myForm = new EditForm(this, int.Parse(PrisonersListView.SelectedItems[0].SubItems[0].Text));
                myForm.Show();
            }            
        }
    }
}
