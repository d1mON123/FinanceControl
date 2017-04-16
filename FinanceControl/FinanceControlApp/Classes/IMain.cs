using System;

namespace FinanceControlApp.Classes
{
    interface IMain
    {
        void UpdateForm();
        void Butt_Click(object sender, EventArgs e);
        void PrevMonthButton_Click(object sender, EventArgs e);
        void NextMonthButton_Click(object sender, EventArgs e);
        void IncomeDataGridView_Click(object sender, EventArgs e);
        void IncomeDataGridView_DoubleClick(object sender, EventArgs e);
        void OutlayDataGridView_Click(object sender, EventArgs e);
        void OutlayDataGridView_DoubleClick(object sender, EventArgs e);
        void AddOperation(object sender, EventArgs e);
        void EditOperation(object sender, EventArgs e);
        void DeleteOperation(object sender, EventArgs e);
        void OpenTypeDictionary(object sender, EventArgs e);
        void OpenPersonDictionary(object sender, EventArgs e);
        void OpenAccountDictionary(object sender, EventArgs e);
        void ShowIncomeStatsByType(object sender, EventArgs e);
        void ShowIncomeStatsByPerson(object sender, EventArgs e);
        void ShowIncomeStatsByAccount(object sender, EventArgs e);
        void ShowOutlayStatsByType(object sender, EventArgs e);
        void ShowOutlayStatsByPerson(object sender, EventArgs e);
        void ShowOutlayStatsByAccount(object sender, EventArgs e);
        void ShowCurrencyConverter(object sender, EventArgs e);
        void ExportDatabase(object sender, EventArgs e);
    }
}
