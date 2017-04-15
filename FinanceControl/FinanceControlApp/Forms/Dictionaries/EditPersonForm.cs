using FinanceControlDAL.Models;
using FinanceControlDAL.Repos;
using System;
using System.Windows.Forms;
using FinanceControlApp.Classes;

namespace FinanceControlApp.Forms
{
    public partial class EditPersonForm : Form, IDictionaryEdit
    {
        private Person p = null;
        public EditPersonForm()
        {
            InitializeComponent();
        }

        public EditPersonForm(Person p)
        {
            InitializeComponent();
            this.p = p;
        }

        public void EditDictionaryForm_Load(object sender, EventArgs e)
        {
            if (p == null) return;
            personNameBox.Text = p.Name;
        }

        public void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var repo = new PersonRepo())
                {
                    if (p == null)
                        repo.Add(new Person()
                        {
                            Name = personNameBox.Text
                        });
                    else
                    {
                        p.Name = Name = personNameBox.Text;
                        repo.Save(p);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
