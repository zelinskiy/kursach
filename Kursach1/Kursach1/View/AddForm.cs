using System;

using System.Windows.Forms;
using Kursach1.Model;

namespace Kursach1.View
{
    public partial class AddForm : Form
    {

        private MainForm parent;

        public AddForm(MainForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Prisoners.Add(
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
