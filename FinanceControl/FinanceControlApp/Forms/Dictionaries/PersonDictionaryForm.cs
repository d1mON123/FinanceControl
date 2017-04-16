using FinanceControlApp.Classes;
using System;
using System.Windows.Forms;
using FinanceControlDAL.Models;
using FinanceControlDAL.Repos;

namespace FinanceControlApp.Forms
{
    public partial class PersonDictionaryForm : Form, IDictionary
    {
        public PersonDictionaryForm()
        {
            InitializeComponent();
        }

        private void PersonDictionaryForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        public void UpdateGrid()
        {
            try
            {
                using (var repo = new PersonRepo())
                {
                    accountDataGrid.DataSource = repo.GetAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            using (var form = new EditPersonForm())
            {
                form.ShowDialog();
            }
            UpdateGrid();
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            var p = accountDataGrid.CurrentRow?.DataBoundItem as Person;
            if (p == null) return;
            using (var form = new EditPersonForm(p))
            {
                form.ShowDialog();
            }
            UpdateGrid();
        }

        public void DelButton_Click(object sender, EventArgs e)
        {
            var p = accountDataGrid.CurrentRow?.DataBoundItem as Person;
            if (p == null) return;
            if (MessageBox.Show(@"Видалити обране поле?", @"Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.OK)
            {
                try
                {
                    using (var repo = new PersonRepo())
                    {
                        repo.Delete(p);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                UpdateGrid();
            }
        }
    }
}
