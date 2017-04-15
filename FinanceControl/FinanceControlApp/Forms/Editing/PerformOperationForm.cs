using FinanceControlApp.Classes;
using FinanceControlDAL.Models;
using FinanceControlDAL.Repos;
using System;
using System.Windows.Forms;
using Type = FinanceControlDAL.Models.Type;

namespace FinanceControlApp.Forms
{
    public partial class PerformOperationForm : Form, IPerformOperation
    {
        public PerformOperationForm()
        {
            InitializeComponent();
        }

        public void Form_Load(object sender, EventArgs e)
        {
            using (var repo = new AccountRepo())
            {
                incomeAccountComboBox.DataSource = repo.GetAll();
                outlayAccountComboBox.DataSource = repo.GetAll();
            }
            using (var repo = new TypeRepo())
            {
                incomeTypeComboBox.DataSource = repo.GetAll();
                outlayTypeComboBox.DataSource = repo.GetAll();
            }
            using (var repo = new PersonRepo())
            {
                incomePersonComboBox.DataSource = repo.GetAll();
                outlayPersonComboBox.DataSource = repo.GetAll();
            }
            incomeDatePicker.Value = DateTime.Now;
            outlayDatePicker.Value = DateTime.Now;
        }

        public void incomeAddButton_Click(object sender, EventArgs e)
        {
            var a = incomeAccountComboBox.SelectedItem as Account;
            var p = incomePersonComboBox.SelectedItem as Person;
            var t = incomeTypeComboBox.SelectedItem as Type;
            DateTime dt = incomeDatePicker.Value;
            using (var repo = new IncomeRepo())
            {
                repo.Add(new Income()
                {
                    Account_ID = a.ID,
                    Day = dt.Day,
                    Month = dt.Month,
                    Year = dt.Year,
                    Person_ID = p.ID,
                    Type_ID = t.ID,
                    Value = double.Parse(incomeValueBox.Text),
                    Comment = incomeCommentBox.Text
                });
            }
            using (var repo = new AccountRepo())
            {
                a.CurrentAmount += double.Parse(incomeValueBox.Text);
                repo.Save(a);
            }
        }

        public void outlayAddButton_Click(object sender, EventArgs e)
        {
            var a = outlayAccountComboBox.SelectedItem as Account;
            var p = outlayPersonComboBox.SelectedItem as Person;
            var t = outlayTypeComboBox.SelectedItem as Type;
            DateTime dt = outlayDatePicker.Value;
            using (var repo = new OutlayRepo())
            {
                repo.Add(new Outlay()
                {
                    Account_ID = a.ID,
                    Day = dt.Day,
                    Month = dt.Month,
                    Year = dt.Year,
                    Person_ID = p.ID,
                    Type_ID = t.ID,
                    Value = double.Parse(outlayValueBox.Text),
                    Comment = outlayCommentBox.Text
                });
            }
            using (var repo = new AccountRepo())
            {
                a.CurrentAmount -= double.Parse(outlayValueBox.Text);
                repo.Save(a);
            }
        }
    }
}
