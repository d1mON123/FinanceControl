using FinanceControlDAL.Models;
using FinanceControlDAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FinanceControlApp.Forms
{
    public partial class AccountStatsForm : Form
    {
        private int _currentMonth;

        private int _currentYear;

        private readonly string[] _monthArray =
        {
            "Січень", "Лютий", "Березень", "Квітень", "Травень", "Червень", "Липень",
            "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень"
        };

        private int _typeOfData;

        public AccountStatsForm(int typeOfData)
        {
            InitializeComponent();
            _typeOfData = typeOfData;
            if(_typeOfData==1) this.Text += " (Дохід)";
            else this.Text += " (Витрати)";
        }

        private void AccountStatsForm_Load(object sender, EventArgs e)
        {
            var dt = DateTime.Now;
            currMonthLabel.Text = _monthArray[dt.Month - 1] + " " + dt.Year;
            UpdateForm();
        }

        private void UpdateForm()
        {
            string month = currMonthLabel.Text.Substring(0, (currMonthLabel.Text.Length - 5));
            string year = currMonthLabel.Text.Substring(currMonthLabel.Text.Length - 4);
            int index = Array.IndexOf(_monthArray, month);
            int monthQuery = index + 1;
            int yearQuery = int.Parse(year);
            List<Account> accountList;
            using (var repo = new AccountRepo())
            {
                accountList = repo.GetAll();
            }
            if (_typeOfData == 1)
            {
                List<Income> incomeList;
                using (var repo = new IncomeRepo())
                {
                    incomeList = (repo.GetAll()).FindAll(x =>
                        (x.Month == monthQuery && x.Year == yearQuery));
                }
                var list = (from a in incomeList
                        from b in accountList
                        where (a.Account_ID == b.ID)
                        select
                        new
                        {
                            Name = b.Name,
                            Sum = (from m in incomeList where m.Account_ID == b.ID select m.Value).Sum()
                        })
                    .Distinct().ToList();
                chart1.DataSource = list;
                chart2.DataSource = list;
            }
            else
            {
                List<Outlay> outlayList;
                using (var repo = new OutlayRepo())
                {
                    outlayList = (repo.GetAll()).FindAll(x =>
                        (x.Month == monthQuery && x.Year == yearQuery));
                }
                var list = (from a in outlayList
                            from b in accountList
                            where (a.Account_ID == b.ID)
                            select
                            new
                            {
                                Name = b.Name,
                                Sum = (from m in outlayList where m.Account_ID == b.ID select m.Value).Sum()
                            })
                    .Distinct().ToList();
                chart1.DataSource = list;
                chart2.DataSource = list;
                chart1.Series["Series1"].Color = System.Drawing.Color.Red;
                chart2.Series["Series1"].Color = System.Drawing.Color.Red;
            }

            chart1.Series["Series1"].XValueMember = "Name";
            chart1.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.Series["Series1"].YValueMembers = "Sum";
            chart1.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            chart2.Series["Series1"].XValueMember = "Name";
            chart2.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart2.Series["Series1"].YValueMembers = "Sum";
            chart2.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        private void prevMonthButton_Click(object sender, EventArgs e)
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
            _currentMonth = a + 1;
            _currentYear = int.Parse(year);
            UpdateForm();
        }

        private void nextMonthButton_Click(object sender, EventArgs e)
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
            _currentMonth = a + 1;
            _currentYear = int.Parse(year);
            UpdateForm();
        }
    }
}
