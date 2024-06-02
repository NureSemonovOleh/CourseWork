using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class EditCustomerForm : Form
    {
        private Customer customerEdit;
        private DataBase dataBase;
        public EditCustomerForm(Customer customerEdit, DataBase dataBase)
        {
            InitializeComponent();
            this.customerEdit = customerEdit;
            this.dataBase = dataBase;

            txtName.Text = customerEdit.Name;
            txtNumber.Text = customerEdit.Number;
            cmbPrefferedBrand.Items.Add("Відсутня");
            cmbPrefferedBrand.SelectedItem = customerEdit.PrefferedBrand;
            txtPrefferedYear.Text = customerEdit.PrefferedYear.ToString();
            cmbPrefferedCondition.SelectedItem = customerEdit.PrefferedCondition;
            txtBudget.Text = customerEdit.Budget.ToString();
        }
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPrefferedYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cmbPrefferedBrand.Text))
                {
                    MessageBox.Show("Будь ласка,виберіть  марку.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cmbPrefferedCondition.Text))
                {
                    MessageBox.Show("Будь ласка, вкажіть стан авто");
                    return;
                }
                if (!int.TryParse(txtPrefferedYear.Text, out int year) || string.IsNullOrWhiteSpace(txtPrefferedYear.Text))
                {
                    MessageBox.Show("Будь ласка, вкажіть вірний рік.");
                    return;
                }

                if (!int.TryParse(txtBudget.Text, out int budget))
                {
                    MessageBox.Show("Будь ласка, вкажіть вірний бюджет.");
                    return;
                }
                if (!int.TryParse(txtNumber.Text, out int number))
                {
                    MessageBox.Show("Будь ласка, вкажіть вірний бюджет.");
                    return;
                }
                customerEdit.Name = txtName.Text;
                customerEdit.Number = txtNumber.Text;
                customerEdit.PrefferedBrand = cmbPrefferedBrand.SelectedItem.ToString();
                customerEdit.PrefferedYear = year;
                customerEdit.PrefferedCondition = cmbPrefferedCondition.SelectedItem.ToString();
                customerEdit.Budget = budget;

                MessageBox.Show("Зміни збережено.");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
