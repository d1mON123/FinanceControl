using System;

namespace FinanceControlApp.Classes
{
    interface IPerformOperation
    {
        void Form_Load(object sender, EventArgs e);
        void incomeAddButton_Click(object sender, EventArgs e);
        void outlayAddButton_Click(object sender, EventArgs e);
    }
}
