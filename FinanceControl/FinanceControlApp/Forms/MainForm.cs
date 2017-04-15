using FinanceControlDAL.Models;
using FinanceControlDAL.Repos;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using FinanceControlApp.Classes;

namespace FinanceControlApp.Forms
{
    public partial class MainForm : Form, ITest
    {
        private int _currentAccount;

        private int _currentGridView;

        private readonly string[] _monthArray =
        {
            "Січень", "Лютий", "Березень", "Квітень", "Травень", "Червень", "Липень",
            "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень"
        };

        public MainForm()
        {
            InitializeComponent();
            _currentAccount = 0;
        }

        private void UpdateForm()
        {
            string month = currMonthLabel.Text.Substring(0, (currMonthLabel.Text.Length - 5));
            string year = currMonthLabel.Text.Substring(currMonthLabel.Text.Length - 4);
            int a = Array.IndexOf(_monthArray, month);
            int monthQuery = a + 1;
            int yearQuery = int.Parse(year);
            using (var repo = new IncomeRepo())
            {
                incomeDataGridView.DataSource =
                (repo.GetAll()).FindAll(
                    x =>
                        (x.Month == monthQuery && x.Year == yearQuery &&
                         x.Account_ID == _currentAccount));

            }
            using (var repo = new OutlayRepo())
            {
                outlayDataGridView.DataSource =
                (repo.GetAll()).FindAll(
                    x =>
                        (x.Month == monthQuery && x.Year == yearQuery &&
                         x.Account_ID == _currentAccount));

            }
            toolStrip2.Items.Clear();
            using (var repo = new AccountRepo())
            {
                foreach (var item in repo.GetAll())
                {
                    var b = new ToolStripButton
                    {
                        Text = item.Name + "\nБаланс: " + item.CurrentAmount,
                        Tag = item.ID, 
                        Image = imageList1.Images[int.Parse(item.IconID.ToString())],
                        ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
                    };
                    b.Click += Butt_Click;
                    toolStrip2.Items.Add(b);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dt = DateTime.Now;
            currMonthLabel.Text = _monthArray[dt.Month - 1] + " " + dt.Year;
            UpdateForm();
        }

        public void Butt_Click(object sender, EventArgs e)
        {
            var b = sender as ToolStripButton;
            if (b != null) _currentAccount = int.Parse(b.Tag.ToString());
            UpdateForm();
        }

        public void PrevMonthButton_Click(object sender, EventArgs e)
        {
            string month = currMonthLabel.Text.Substring(0, (currMonthLabel.Text.Length - 5));
            string year = currMonthLabel.Text.Substring(currMonthLabel.Text.Length - 4);
            int a = Array.IndexOf(_monthArray, month);
            if (a == 0)
            {
                currMonthLabel.Text = currMonthLabel.Text.Replace(_monthArray[a], _monthArray[11]);
                currMonthLabel.Text = currMonthLabel.Text.Replace(year, (int.Parse(year) - 1).ToString());
                a = 11;
            }
            else
            {
                currMonthLabel.Text = currMonthLabel.Text.Replace(_monthArray[a], _monthArray[a - 1]);
                a--;
            }
            year = currMonthLabel.Text.Substring(currMonthLabel.Text.Length - 4);
            using (var repo = new IncomeRepo())
            {
                int monthQuery = a + 1;
                int yearQuery = int.Parse(year);
                incomeDataGridView.DataSource =
                    (repo.GetAll()).FindAll(
                        x =>
                            (x.Month == monthQuery && x.Year == yearQuery &&
                             x.Account_ID == _currentAccount));

            }
            using (var repo = new OutlayRepo())
            {
                int monthQuery = a + 1;
                int yearQuery = int.Parse(year);
                outlayDataGridView.DataSource =
                    (repo.GetAll()).FindAll(
                        x =>
                            (x.Month == monthQuery && x.Year == yearQuery &&
                             x.Account_ID == _currentAccount));

            }
        }

        /*private void PrevMonthButton_Click(object sender, EventArgs e)
        {
            
        }*/

        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            string month = currMonthLabel.Text.Substring(0, (currMonthLabel.Text.Length - 5));
            string year = currMonthLabel.Text.Substring(currMonthLabel.Text.Length - 4);
            int a = Array.IndexOf(_monthArray, month);
            if (a == 11)
            {
                currMonthLabel.Text = currMonthLabel.Text.Replace(_monthArray[a], _monthArray[0]);
                currMonthLabel.Text = currMonthLabel.Text.Replace(year, (int.Parse(year) + 1).ToString());
                a = 0;
            }
            else
            {
                currMonthLabel.Text = currMonthLabel.Text.Replace(_monthArray[a], _monthArray[a + 1]);
                a++;
            }
            year = currMonthLabel.Text.Substring(currMonthLabel.Text.Length - 4);
            using (var repo = new IncomeRepo())
            {
                int monthQuery = a + 1;
                int yearQuery = int.Parse(year);
                incomeDataGridView.DataSource =
                    (repo.GetAll()).FindAll(
                        x =>
                            (x.Month == monthQuery && x.Year == yearQuery &&
                             x.Account_ID == _currentAccount));
            }
            using (var repo = new OutlayRepo())
            {
                int monthQuery = a + 1;
                int yearQuery = int.Parse(year);
                outlayDataGridView.DataSource =
                    (repo.GetAll()).FindAll(
                        x =>
                            (x.Month == monthQuery && x.Year == yearQuery &&
                             x.Account_ID == _currentAccount));
            }
        }

        private void IncomeDataGridView_Click(object sender, EventArgs e)
        {
            _currentGridView = 1;
        }

        private void IncomeDataGridView_DoubleClick(object sender, EventArgs e)
        {
            var i = incomeDataGridView.CurrentRow?.DataBoundItem as Income;
            if (i == null) return;
            using (var form = new DetInfoForm(1, int.Parse(i.ID.ToString())))
            {
                form.ShowDialog();
            }
        }

        private void OutlayDataGridView_Click(object sender, EventArgs e)
        {
            _currentGridView = 2;
        }

        private void OutlayDataGridView_DoubleClick(object sender, EventArgs e)
        {
            var o = outlayDataGridView.CurrentRow?.DataBoundItem as Outlay;
            if (o == null) return;
            using (var form = new DetInfoForm(2, int.Parse(o.ID.ToString())))
            {
                form.ShowDialog();
            }
        }

        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new PerformOperationForm())
            {
                if (form.ShowDialog() == DialogResult.OK) UpdateForm();
            }
        }

        private void типToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AddTypeForm())
            {
                if (form.ShowDialog() == DialogResult.OK) UpdateForm();
            }
        }

        private void члениСіміToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AddPersonForm())
            {
                if (form.ShowDialog() == DialogResult.OK) UpdateForm();
            }
        }

        private void рахункиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AddAccountForm())
            {
                if (form.ShowDialog() == DialogResult.OK) UpdateForm();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var form = new ExportForm())
            {
                form.ShowDialog();
            }
        }

        private void поРахункахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AccountStatsForm(1))
            {
                form.ShowDialog();
            }
        }

        private void поРахункахToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (var form = new AccountStatsForm(2))
            {
                form.ShowDialog();
            }
        }

        private void поКатегоріяхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new TypeStatsForm(1))
            {
                form.ShowDialog();
            }
        }

        private void поКатегоріяхToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (var form = new TypeStatsForm(2))
            {
                form.ShowDialog();
            }
        }

        private void конвертерВалютToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ExchangeRateForm())
            {
                form.ShowDialog();
            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentGridView == 0) return;
            else if (_currentGridView == 1)
            {
                var i = incomeDataGridView.CurrentRow?.DataBoundItem as Income;
                if (i == null) return;
                if (MessageBox.Show("Видалити обране поле?", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.OK)
                {
                    using (var repo = new IncomeRepo())
                    {
                        repo.Delete(i);
                    }
                }
            }
            else
            {
                var o = outlayDataGridView.CurrentRow?.DataBoundItem as Outlay;
                if (o == null) return;
                if (MessageBox.Show("Видалити обране поле?", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.OK)
                {
                    using (var repo = new OutlayRepo())
                    {
                        repo.Delete(o);
                    }
                }
            }
            UpdateForm();
        }

        private void поЧленахСімїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new PersonStatsForm(1))
            {
                form.ShowDialog();
            }
        }

        private void поЧленахСімїToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var form = new PersonStatsForm(2))
            {
                form.ShowDialog();
            }
        }

        private void експортБазиДаннихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
            }
            using (var repo = new AccountRepo())
            {
                var xEle = new XElement("Accounts",
                    repo.GetAll().Select(account => new XElement("Account",
                        new XAttribute("ID", account.ID),
                        new XElement("Name", account.Name),
                        new XElement("CurrentAmount", account.CurrentAmount)
                    )));
                xEle.Save($"{path}\\accounts.xml");
            }
            using (var repo = new TypeRepo())
            {
                var xEle = new XElement("Types",
                    repo.GetAll().Select(type => new XElement("Type",
                        new XAttribute("ID", type.ID),
                        new XElement("Name", type.Name)
                    )));
                xEle.Save($"{path}\\types.xml");
            }
            using (var repo = new PersonRepo())
            {
                var xEle = new XElement("Persons",
                    repo.GetAll().Select(account => new XElement("Person",
                        new XAttribute("ID", account.ID),
                        new XElement("Name", account.Name)
                    )));
                xEle.Save($"{path}\\persons.xml");
            }
            using (var repo = new IncomeRepo())
            {
                var xEle = new XElement("Incomes",
                    repo.GetAll().Select(income => new XElement("Income",
                        new XAttribute("ID", income.ID),
                        new XElement("Account", income.Account),
                        new XElement("Day", income.Day),
                        new XElement("Month", income.Month),
                        new XElement("Year", income.Year),
                        new XElement("Person", income.Person),
                        new XElement("Type", income.Type),
                        new XElement("Account", income.Value),
                        new XElement("Comment", income.Comment)
                    )));
                xEle.Save($"{path}\\incomes.xml");
            }
            using (var repo = new OutlayRepo())
            {
                var xEle = new XElement("Outlays",
                    repo.GetAll().Select(outlay => new XElement("Outlay",
                        new XAttribute("ID", outlay.ID),
                        new XElement("Account", outlay.Account),
                        new XElement("Day", outlay.Day),
                        new XElement("Month", outlay.Month),
                        new XElement("Year", outlay.Year),
                        new XElement("Person", outlay.Person),
                        new XElement("Type", outlay.Type),
                        new XElement("Account", outlay.Value),
                        new XElement("Comment", outlay.Comment)
                    )));
                xEle.Save($"{path}\\outlays.xml");
            }
        }

        
    }
}
