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
    public partial class EditForm : Form
    {
        private MainForm parent;
        private int id;

        public EditForm(MainForm parent, int Id)
        {
            this.id = Id;
            this.parent = parent;
            InitializeComponent();
        }

        public void EditForm_Load(object o, EventArgs e)
        {
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
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            

        }

        private void EditButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                Prisoners.Replace(
                        id: id,
                        firstName: FirstNameTextBox.Text,
                        secondName: SecondNameTextBox.Text,
                        patronimyc: PatronymicTextBox.Text,
                        birthday: BirthdayPicker.Value,

                        article: ArticleBox.Text,
                        cell: CellBox.Text,
                        sentenceYears: SentenceYearsBox.Text,
                        sentenceMonths: SentenceYearsBox.Text,
                        imprisonedDate: ImprisonedDatePicker.Value,
                        hierarchy: HierarchyPlaceTextBox.Text
                        );

                parent.RefreshView(Prisoners.prisoners);
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Please , Check your data!\n" + ex.Message);
            }
        }
    }
}
