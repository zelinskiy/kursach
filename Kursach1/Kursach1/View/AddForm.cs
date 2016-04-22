﻿using System;

using System.Windows.Forms;
using Kursach1.Model;

namespace Kursach1.View
{
    public partial class AddForm : Form
    {

        public MainForm parent;

        public AddForm() { }


        public AddForm(MainForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    AddButton_Click(null, null);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        public Prisoner LoadPrisonerFromInput()
        {
            try
            {
                return new Prisoner(
                        firstName: FirstNameTextBox.Text,
                        secondName: SecondNameTextBox.Text,
                        patronimyc: PatronymicTextBox.Text,
                        birthday: BirthdayPicker.Value,

                        article: ArticleBox.Text,
                        cell: CellBox.Text,
                        sentenceYears: SentenceYearsBox.Text,
                        sentenceMonths: SentenceMonthsBox.Text,
                        imprisonedDate: ImprisonedDatePicker.Value,
                        hierarchy: HierarchyPlaceTextBox.Text
                        );
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Please , Check your data!\n" + ex.Message);
            }
            //?????????
            return null;
        }


        protected virtual void AddButton_Click(object sender, EventArgs e)
        {
            Prisoners.Add(LoadPrisonerFromInput());   
            parent.RefreshView(Prisoners.prisoners);
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
