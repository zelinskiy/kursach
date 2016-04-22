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

        public bool Ascending = false;

        public Dictionary<string, Func<Prisoner, string>> fields = new Dictionary<string, Func<Prisoner, string>>()
        {
            { "Фамилия",p=>p.SecondName },
            { "Номер",p=>p.Id.ToString() },
            { "Возраст",p=>p.Age.ToString() },
            { "Статья",p=>p.Article.ToString() },
            { "Камера",p=>p.Cell.ToString() },
            { "Ост. дней",p=>p.SentenceDaysLeft.ToString() },
            { "Иерархич.",p=>p.Hierarchy },
             { "Заключен.",p=>p.Imprisoned.DayOfWeek.ToString() },
        };



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

            

            string[] fieldNames = fields.Keys.ToArray();

            for(int i=0; i< fieldNames.Length; i++)
            {
                PrisonersListView.Columns.Add(fieldNames[i],150);
                SearchFieldComboBox.Items.Add(fieldNames[i]);
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
                case Keys.F11:
                    EditButton_Click(null, null);
                    break;
                case Keys.F12:
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
                List<string> row = new List<string>();

                foreach(Func<Prisoner, string> f in fields.Values)
                {
                    row.Add(f(p));
                }

                PrisonersListView.Items.Add(new ListViewItem(row.ToArray()));
            }

            PrisonersListView.Focus();

            PrisonersListView.MultiSelect = false;
        }

        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            Func<Prisoner, string> field = fields.Values.ToList()[e.Column];
            RefreshView(MyPrison.OrderBy(field, Ascending));
            Ascending = !Ascending;
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
            string pattern = SearchTextBox.Text;
            Func<Prisoner, string> field = fields.Values.ToList()[SearchFieldComboBox.SelectedIndex];
            bool strict = IsStrictCheckBox.Checked;
            RefreshView(MyPrison.SearchBy(field, pattern, strict));
        }


        private void TestDataButton_Click(object sender, EventArgs e)
        {
            MyPrison.Create();
            RefreshView(MyPrison.prisoners);
        }





        


        

        

        
    }
}
