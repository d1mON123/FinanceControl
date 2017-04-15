using FinanceControlDAL.Repos;
using System;
using System.Windows.Forms;

namespace FinanceControlApp.Forms
{
    public partial class AddTypeForm : Form
    {
        public AddTypeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var repo = new TypeRepo())
            {
                repo.Add(new FinanceControlDAL.Models.Type() {Name = textBox1.Text});
            }
        }
    }
}
