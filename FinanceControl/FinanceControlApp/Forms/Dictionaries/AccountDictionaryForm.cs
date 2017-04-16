using FinanceControlApp.Classes;
using FinanceControlDAL.Models;
using FinanceControlDAL.Repos;
using System;
using System.Windows.Forms;

namespace FinanceControlApp.Forms
{
    public partial class AccountDictionaryForm : Form, IDictionary
    {
        public AccountDictionaryForm()
        {
            InitializeComponent();
        }

        private void AccountDictionaryForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        public void UpdateGrid()
        {
            try
            {
                using (var repo = new AccountRepo())
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
            using (var form = new EditAccountForm())
            {
                if (form.ShowDialog() == DialogResult.OK) UpdateGrid();
            }
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            var a = accountDataGrid.CurrentRow?.DataBoundItem as Account;
            if (a == null) return;
            using (var form = new EditAccountForm(a))
            {
                form.ShowDialog();
            }
            UpdateGrid();
        }

        public void DelButton_Click(object sender, EventArgs e)
        {
            var a = accountDataGrid.CurrentRow?.DataBoundItem as Account;
            if (a == null) return;
            if (MessageBox.Show(@"Видалити обране поле?", @"Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.OK)
            {
                try
                {
                    using (var repo = new AccountRepo())
                    {
                        repo.Delete(a);
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
