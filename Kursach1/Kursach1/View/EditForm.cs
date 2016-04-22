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
    public partial class EditForm : AddForm
    {

        private int Id;
        
        

        private EditForm(MainForm p) : base(p) { }

        public EditForm(MainForm parent, int id): base(parent)
        {
            Id = id;
            this.InitializeComponent();
            

            Prisoner p = Prisoners.prisoners.First(x => x.Id == id);

            FirstNameTextBox.Text = p.FirstName;
            SecondNameTextBox.Text = p.SecondName;
            PatronymicTextBox.Text = p.Patronymic;
            BirthdayPicker.Value = p.Birthday;

            ArticleBox.Text = p.Article.ToString();
            CellBox.Text = p.Cell.ToString();
            SentenceYearsBox.Text = p.Sentence.Years.ToString();
            SentenceYearsBox.Text = p.Sentence.Months.ToString();
            ImprisonedDatePicker.Value = p.Imprisoned;
            HierarchyPlaceTextBox.Text = p.Hierarchy;

            AddButton.Text = "Edit";



        }

        protected override void AddButton_Click(object sender, EventArgs e)
        {
            Prisoners.Replace(Id, LoadPrisonerFromInput());
            parent.RefreshView(Prisoners.prisoners);
            this.Close();
        }


    }
}
