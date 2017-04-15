using FinanceControlDAL.Models;
using FinanceControlDAL.Repos;
using System;
using System.Windows.Forms;

namespace FinanceControlApp.Forms
{
    public partial class AddPersonForm : Form
    {
        public AddPersonForm()
        {
            InitializeComponent();
        }

        private void personAddButton_Click(object sender, EventArgs e)
        {
            using (var repo = new PersonRepo())
            {
                repo.Add(new Person() { Name = personNameBox.Text });
            }
        }
    }
}
