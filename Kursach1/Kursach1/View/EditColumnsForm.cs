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
    public partial class EditColumnsForm : Form
    {

        public MainForm parent;
        

        public Dictionary<string, Func<Prisoner, string>> selFields;
        public Dictionary<string, Func<Prisoner, string>> notselFields;


        public EditColumnsForm(MainForm parent)
        {
            this.parent = parent;

            InitializeComponent();
            SelectedColumnsListBox.MouseDoubleClick += new MouseEventHandler(SelectedColumnsListBox_DoubleClick);
            NotSelectedColumnsListBox.MouseDoubleClick += new MouseEventHandler(NotSelectedColumnsListBox_DoubleClick);

            selFields = new Dictionary<string, Func<Prisoner, string>>();
            foreach(KeyValuePair<string, Func < Prisoner, string>> p in parent.selectedFields)
            {
                selFields.Add(p.Key, p.Value);
            }
            notselFields = parent.allFields
                .Where(x => !selFields.Keys.ToList()
                    .Exists(k => k == x.Key))
                .ToDictionary(k => k.Key, v => v.Value);

            RefreshLists();
        }



        public void RefreshLists()
        {
            SelectedColumnsListBox.Items.Clear();
            NotSelectedColumnsListBox.Items.Clear();
            foreach (string col in selFields.Keys)
            {
                SelectedColumnsListBox.Items.Add(col);
            }
            foreach (string col in notselFields.Keys)
            {
                NotSelectedColumnsListBox.Items.Add(col);
            }
        }




        private void RemoveColumnButton_Click(object sender, EventArgs e)
        {
            //selFields->notsel
            if(SelectedColumnsListBox.SelectedItems.Count > 0)
            {
                string selected = SelectedColumnsListBox.SelectedItem.ToString();
                if(notselFields.Keys.Where(x=>x.ToString() == selected).ToList().Count == 0)
                {
                    notselFields.Add(selected, selFields[selected]);
                    selFields.Remove(selected);
                }

            }
            //notselFields->selFields
            else if (NotSelectedColumnsListBox.SelectedItems.Count > 0)
            {
                string selected = NotSelectedColumnsListBox.SelectedItem.ToString();
                if (selFields.Keys.Where(x => x.ToString() == selected).ToList().Count == 0)
                {
                    selFields.Add(selected, notselFields[selected]);
                    notselFields.Remove(selected);
                }
            }
            RefreshLists();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            parent.selectedFields = this.selFields;
            Close();
        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    ExitButton_Click(null, null);
                    break;
                case Keys.Enter:
                    RemoveColumnButton_Click(null, null);
                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void SelectedColumnsListBox_DoubleClick(object sender, EventArgs e)
        {
            RemoveColumnButton_Click(null, null);
        }

        private void NotSelectedColumnsListBox_DoubleClick(object sender, EventArgs e)
        {
            RemoveColumnButton_Click(null, null);
        }

    }
}
