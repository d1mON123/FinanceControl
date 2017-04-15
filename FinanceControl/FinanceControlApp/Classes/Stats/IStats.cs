using System;

namespace FinanceControlApp.Classes
{
    interface IStats
    {
        void StatsForm_Load(object sender, EventArgs e);
        void UpdateForm();
        void prevMonthButton_Click(object sender, EventArgs e);
        void nextMonthButton_Click(object sender, EventArgs e);
    }
}
