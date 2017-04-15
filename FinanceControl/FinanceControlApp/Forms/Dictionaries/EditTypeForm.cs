using FinanceControlApp.Classes;
using FinanceControlDAL.Repos;
using System;
using System.Windows.Forms;
using Type = FinanceControlDAL.Models.Type;

namespace FinanceControlApp.Forms
{
    public partial class EditTypeForm : Form, IDictionaryEdit
    {
        private Type t = null;
        public EditTypeForm()
        {
            InitializeComponent();
        }

        public EditTypeForm(Type t)
        {
            InitializeComponent();
            this.t = t;
        }

        public void EditDictionaryForm_Load(object sender, EventArgs e)
        {
            if (t == null) return;
            typeNameBox.Text = t.Name;
        }

        public void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var repo = new TypeRepo())
                {
                    if (t == null)
                        repo.Add(new Type()
                        {
                            Name = typeNameBox.Text
                        });
                    else
                    {
                        t.Name = Name = typeNameBox.Text;
                        repo.Save(t);
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
