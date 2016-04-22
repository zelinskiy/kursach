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

        public Prisoners MyPrison;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Prisoners ps)
        {
            MyPrison = ps;
            InitializeComponent();
        }


        //List View

        private void MainForm_Load(object sender, EventArgs e)
        {

            PrisonersListView.View = System.Windows.Forms.View.Details;
            PrisonersListView.GridLines = true;
            PrisonersListView.FullRowSelect = true;
            
            PrisonersListView.MouseDoubleClick += new MouseEventHandler(PrisonersListView_DoubleClick);

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

            MyPrison.Load();
            RefreshView(MyPrison.prisoners);

            

        }


        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Delete:
                    DeleteButton_Click(null, null);
                    break;
                case Keys.E:
                    EditButton_Click(null, null);
                    break;
                case Keys.N:
                    AddPrisonerButton_Click(null, null);
                    break;
                case Keys.Enter:
                    SearchButton_Click(null, null);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void PrisonersListView_DoubleClick(object sender, EventArgs e)
        {
            EditButton_Click(null, null);
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

        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            RefreshView(MyPrison.OrderBy(e.Column.ToString()));
        }

       



        //BUTTONS

        private void ShowStatisticsButton_Click(object sender, EventArgs e)
        {
            var myForm = new StatsForm(this);
            myForm.Show();
        }


        private void AddPrisonerButton_Click(object sender, EventArgs e)
        {
            var myForm = new AddForm(this);
            myForm.Show();
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PrisonersListView.SelectedItems.Count == 1)
            {
                int myId = int.Parse(PrisonersListView.SelectedItems[0].SubItems[0].Text);
                var myForm = new EditForm(this, myId);
                myForm.Show();
            }
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PrisonersListView.SelectedItems.Count == 1)
            {
                MyPrison.Remove(PrisonersListView.SelectedItems[0].SubItems[0].Text);
                RefreshView(MyPrison.prisoners);
            }            
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            RefreshView(MyPrison.SearchBy(SearchFieldComboBox.SelectedIndex.ToString(), SearchTextBox.Text));
        }


        private void TestDataButton_Click(object sender, EventArgs e)
        {
            MyPrison.Create();
        }





        


        

        

        
    }
}
