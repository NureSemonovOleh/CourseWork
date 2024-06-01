using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddCustomerForm : Form
    {
        private DataBase dataBase;
        public event EventHandler CustomerAdded;
        public AddCustomerForm(DataBase database)
        {
            InitializeComponent();
            dataBase = database;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Будь ласка,введіть ім'я покупця");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNumber.Text))
                {
                    MessageBox.Show("Будь ласка,введіть номер");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cmbPrefferedBrand.Text))
                {
                    MessageBox.Show("Будь ласка,виберіть бажану марку");
                    return;
                }
                if (!int.TryParse(txtPrefferedYear.Text, out int year) || string.IsNullOrWhiteSpace(txtPrefferedYear.Text))
                {
                    MessageBox.Show("Будь ласка, вкажіть вірний рік");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cmbPrefferedCondition.Text))
                {
                    MessageBox.Show("Будь ласка,виберіть стан авто");
                    return;
                }
                if (!int.TryParse(txtBudget.Text, out int price))
                {
                    MessageBox.Show("Будь ласка, вкажіть вірний бюджет");
                    return;
                }
                var customer = new Customer
                {
                    Id = dataBase.Customers.Count > 0 ? dataBase.Customers.Max(x => x.Id) + 1 : 1,
                    Name = txtName.Text,
                    Number = txtNumber.Text,
                    PrefferedBrand = cmbPrefferedBrand.Text,
                    PrefferedCondition = cmbPrefferedCondition.Text,
                    PrefferedYear = int.Parse(txtPrefferedYear.Text),

                    Budget = int.Parse(txtBudget.Text)
                };
                dataBase.Customers.Add(customer);
                CustomerAdded?.Invoke(this, EventArgs.Empty);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
    }
}
