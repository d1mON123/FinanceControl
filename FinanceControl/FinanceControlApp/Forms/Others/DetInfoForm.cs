using FinanceControlDAL.Repos;
using System;
using System.Windows.Forms;
using FinanceControlApp.Classes;

namespace FinanceControlApp.Forms
{
    public partial class DetInfoForm : Form, IDetails
    {
        private readonly int _typeOfData;
        private readonly int _id;
        public DetInfoForm(int typeOfData, int id)
        {
            InitializeComponent();
            _typeOfData = typeOfData;
            _id = id;
        }

        public void DetInfoForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (_typeOfData == 1)
                {
                    Text = "Дохід";
                    using (var repo = new IncomeRepo())
                    {
                        var i = repo.GetOne(_id);
                        dayBox.Text = i.Day.ToString();
                        monthBox.Text = i.Month.ToString();
                        yearBox.Text = i.Year.ToString();
                        personBox.Text = i.Person.Name;
                        accountBox.Text = i.Account.Name;
                        typeBox.Text = i.Type.Name;
                        valieBox.Text = i.Value.ToString();
                        commentBox.Text = i.Comment;
                    }
                }
                else
                {
                    Text = "Витрата";
                    using (var repo = new OutlayRepo())
                    {
                        var o = repo.GetOne(_id);
                        dayBox.Text = o.Day.ToString();
                        monthBox.Text = o.Month.ToString();
                        yearBox.Text = o.Year.ToString();
                        personBox.Text = o.Person.Name;
                        accountBox.Text = o.Account.Name;
                        typeBox.Text = o.Type.Name;
                        valieBox.Text = o.Value.ToString();
                        commentBox.Text = o.Comment;
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
