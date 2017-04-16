using FinanceControlApp.Classes;
using FinanceControlDAL.Repos;
using System;
using System.Windows.Forms;
using Type = FinanceControlDAL.Models.Type;

namespace FinanceControlApp.Forms
{
    public partial class TypeDictionaryForm : Form, IDictionary
    {
        public TypeDictionaryForm()
        {
            InitializeComponent();
        }

        private void TypeDictionaryForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        public void UpdateGrid()
        {
            using (var repo = new TypeRepo())
            {
                accountDataGrid.DataSource = repo.GetAll();
            }
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            using (var form = new EditTypeForm())
            {
                if (form.ShowDialog() == DialogResult.OK) UpdateGrid();
            }
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            var t = accountDataGrid.CurrentRow?.DataBoundItem as Type;
            if (t == null) return;
            using (var form = new EditTypeForm(t))
            {
                form.ShowDialog();
            }
            UpdateGrid();
        }

        public void DelButton_Click(object sender, EventArgs e)
        {
            var t = accountDataGrid.CurrentRow?.DataBoundItem as Type;
            if (t == null) return;
            if (MessageBox.Show("Видалити обране поле?", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.OK)
            {
                using (var repo = new TypeRepo())
                {
                    repo.Delete(t);
                }
                UpdateGrid();
            }
        }
    }
}
