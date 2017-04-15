using FinanceControlApp.Classes;
using FinanceControlDAL.Models;
using FinanceControlDAL.Repos;
using System;
using System.Windows.Forms;

namespace FinanceControlApp.Forms
{
    public partial class EditAccountForm : Form, IDictionaryEdit
    {
        private Account a = null;
        public EditAccountForm()
        {
            InitializeComponent();
        }

        public EditAccountForm(Account a)
        {
            InitializeComponent();
            this.a = a;
        }

        public void EditDictionaryForm_Load(object sender, EventArgs e)
        {
            if (a == null) return;
            accountNameBox.Text = a.Name;
            accountCurrAmountBox.Text = a.CurrentAmount.ToString();
            imageComboBox1.SelectedIndex = int.Parse(a.IconID.ToString());
        }

        public void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var repo = new AccountRepo())
                {
                    if (a == null)
                        repo.Add(new Account()
                        {
                            Name = accountNameBox.Text,
                            CurrentAmount = double.Parse(accountCurrAmountBox.Text),
                            IconID = imageComboBox1.SelectedIndex
                        });
                    else
                    {
                        a.Name = Name = accountNameBox.Text;
                        a.CurrentAmount = double.Parse(accountCurrAmountBox.Text);
                        a.IconID = imageComboBox1.SelectedIndex;
                        repo.Save(a);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
