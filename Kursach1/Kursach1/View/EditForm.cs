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


//TODO: passing MyPrison as parameter, not the whole form
namespace Kursach1.View
{
    public partial class EditForm : AddForm
    {

        private int Id;

        public new Prisoners MyPrison;

        private EditForm(Prisoners p) : base(p) { }

        public EditForm(Prisoners Prison, int id): base(Prison)
        {
            Id = id;
            MyPrison = Prison;
            this.InitializeComponent();

            LoadDataToInputFields();
            CellBox.Enabled = false;

            AddButton.Text = "Edit";
        }


        private void LoadDataToInputFields()
        {
            Prisoner p = MyPrison.prisoners.First(x => x.Id == Id);

            FirstNameTextBox.Text = p.FirstName;
            SecondNameTextBox.Text = p.SecondName;
            PatronymicTextBox.Text = p.Patronymic;
            BirthdayPicker.Value = p.Birthday;
            ArticleBox.Text = p.Article.ToString();
            CellBox.Text = p.Cell.ToString() + " (используйте Конвой)";
            SentenceYearsBox.Text = p.Sentence.Years.ToString();
            SentenceYearsBox.Text = p.Sentence.Months.ToString();
            ImprisonedDatePicker.Value = p.Imprisoned;
            HierarchyPlaceTextBox.Text = p.Hierarchy;
        }


        protected override void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                MyPrison.Replace(Id, LoadPrisonerFromInput());
                this.Close();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ConvoyButton_Click(object sender, EventArgs e)
        {
            var myForm = new ConvoyForm(MyPrison, Id);
            myForm.Show();
            myForm.FormClosed += MyForm_FormClosed;
        }


        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDataToInputFields();
        }
    }
}
