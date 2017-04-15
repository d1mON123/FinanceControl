using FinanceControlDAL.Models;
using FinanceControlDAL.Repos;
using System;
using System.Windows.Forms;

namespace FinanceControlApp.Forms
{
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var repo = new AccountRepo())
            {
                repo.Add(new Account() {Name = accountNameBox.Text, CurrentAmount = double.Parse(accountCurrAmountBox.Text), IconID = imageComboBox1.SelectedIndex});
            }
        }
    }
}
