using FinanceControlApp.Classes;
using FinanceControlDAL.Models;
using FinanceControlDAL.Repos;
using System;
using System.Linq;
using System.Windows.Forms;
using Type = FinanceControlDAL.Models.Type;

namespace FinanceControlApp.Forms
{
    public partial class EditOperationForm : Form, IPerformOperation
    {
        private Income i = null;
        private Outlay o = null;
        public EditOperationForm()
        {
            InitializeComponent();
        }

        public EditOperationForm(Income i)
        {
            InitializeComponent();
            this.i = i;
        }

        public EditOperationForm(Outlay o)
        {
            InitializeComponent();
            this.o = o;
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

            if (i != null)
            {
                tabControl1.TabPages.Remove(tabPage2);
                incomeAccountComboBox.SelectedIndex = incomeAccountComboBox.Items.Cast<Account>().ToList().FindIndex(x => (x.ID == i.Account_ID));
                incomeDatePicker.Value = new DateTime(int.Parse(i.Year.ToString()), int.Parse(i.Month.ToString()), int.Parse(i.Day.ToString()));
                incomeTypeComboBox.SelectedIndex = incomeTypeComboBox.Items.Cast<Type>().ToList().FindIndex(x => (x.ID == i.Type_ID));
                incomePersonComboBox.SelectedIndex = incomePersonComboBox.Items.Cast<Person>().ToList().FindIndex(x => (x.ID == i.Person_ID));
                incomeValueBox.Text = i.Value.ToString();
                incomeCommentBox.Text = i.Comment;

            }
            else if (o != null)
            {
                tabControl1.TabPages.Remove(tabPage1);
                outlayAccountComboBox.SelectedIndex = outlayAccountComboBox.Items.Cast<Account>().ToList().FindIndex(x => (x.ID == o.Account_ID));
                outlayDatePicker.Value = new DateTime(int.Parse(o.Year.ToString()), int.Parse(o.Month.ToString()), int.Parse(o.Day.ToString()));
                outlayTypeComboBox.SelectedIndex = outlayTypeComboBox.Items.Cast<Type>().ToList().FindIndex(x => (x.ID == o.Type_ID));
                outlayPersonComboBox.SelectedIndex = outlayPersonComboBox.Items.Cast<Person>().ToList().FindIndex(x => (x.ID == o.Person_ID));
                outlayValueBox.Text = o.Value.ToString();
                outlayCommentBox.Text = o.Comment;
            }
        }

        public void incomeAddButton_Click(object sender, EventArgs e)
        {
            var a = incomeAccountComboBox.SelectedItem as Account;
            var p = incomePersonComboBox.SelectedItem as Person;
            var t = incomeTypeComboBox.SelectedItem as Type;
            DateTime dt = incomeDatePicker.Value;
            if (i == null)
            {
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
            else
            {
                using (var repo = new AccountRepo())
                {
                    a.CurrentAmount -= i.Value;
                    a.CurrentAmount += double.Parse(incomeValueBox.Text);
                    repo.Save(a);
                }
                using (var repo = new IncomeRepo())
                {
                    i.Account_ID = a.ID;
                    i.Day = dt.Day;
                    i.Month = dt.Month;
                    i.Year = dt.Year;
                    i.Person_ID = p.ID;
                    i.Type_ID = t.ID;
                    i.Value = double.Parse(incomeValueBox.Text);
                    i.Comment = incomeCommentBox.Text;
                    repo.Save(i);
                }
            }
            
        }

        public void outlayAddButton_Click(object sender, EventArgs e)
        {
            var a = outlayAccountComboBox.SelectedItem as Account;
            var p = outlayPersonComboBox.SelectedItem as Person;
            var t = outlayTypeComboBox.SelectedItem as Type;
            DateTime dt = outlayDatePicker.Value;
            if (o == null)
            {
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
            else
            {
                using (var repo = new AccountRepo())
                {
                    a.CurrentAmount += o.Value;
                    a.CurrentAmount -= double.Parse(outlayValueBox.Text);
                    repo.Save(a);
                }
                using (var repo = new OutlayRepo())
                {
                    o.Account_ID = a.ID;
                    o.Day = dt.Day;
                    o.Month = dt.Month;
                    o.Year = dt.Year;
                    o.Person_ID = p.ID;
                    o.Type_ID = t.ID;
                    o.Value = double.Parse(outlayValueBox.Text);
                    o.Comment = outlayCommentBox.Text;
                    repo.Save(o);
                }
            }
        }
    }
}
