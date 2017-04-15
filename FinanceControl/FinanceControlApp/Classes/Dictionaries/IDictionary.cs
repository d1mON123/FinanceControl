using System;

namespace FinanceControlApp.Classes
{
    interface IDictionary
    {
        void UpdateGrid();
        void AddButton_Click(object sender, EventArgs e);
        void EditButton_Click(object sender, EventArgs e);
        void DelButton_Click(object sender, EventArgs e);
    }
}
