using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class CustomersPage : Form
    {
        private DataBase dataBase;
        private CarsPage mainWindow;
        private const string FilePath = "database.json";

        public CustomersPage(DataBase database, CarsPage mainwindow)
        {
            InitializeComponent();
            dataBase = database;
            mainWindow = mainwindow;
            UpdateCustomers();
            FormClosing += CustomersPage_FormClosing;

        }

        private void CustomersPage_FormClosing(object? sender, FormClosingEventArgs e)
        {


            Application.Exit();

        }

        private void UpdateCustomers()
        {
            dgvCustomers.Rows.Clear();
            foreach (var customer in dataBase.Customers)
            {
                dgvCustomers.Rows.Add(
                    customer.Id,
                    customer.Name,
                    customer.Number,
                    customer.PrefferedBrand,
                    customer.PrefferedCondition,
                    customer.PrefferedYear,
                    customer.Budget);
            }
        }
        private void btnMainPage_Click(object sender, EventArgs e)
        {

            mainWindow.Show();
            this.Hide();
        }
        private void btnRequestPage_Click(object sender, EventArgs e)
        {
            var requestPage = new RequestPage(dataBase, mainWindow);
            requestPage.Show();
            this.Hide();

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomerForm(dataBase);
            addCustomerForm.CustomerAdded += AddCustomerForm_CustomerAdded;
            addCustomerForm.ShowDialog();
        }
        private void AddCustomerForm_CustomerAdded(object sender, EventArgs e)
        {
            UpdateCustomers();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Ви впевнені,що хочете видалити цього покупця?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    int selectedCustomerId = (int)dgvCustomers.SelectedRows[0].Cells["dgvTxtId"].Value;
                    var customerRemove = dataBase.Customers.FirstOrDefault(customer => customer.Id == selectedCustomerId);
                    if (customerRemove != null)
                    {
                        dataBase.Customers.Remove(customerRemove);
                        RecalcId();
                        UpdateCustomers();

                        MessageBox.Show("Клієнта видалено успішно");
                    }
                    else
                    {
                        MessageBox.Show("Клієнта не знайдено");
                    }

                }
            }
            else
            {
                MessageBox.Show("Будь ласка,виберіть клієнта для видалення");
            }
        }
        private void RecalcId()
        {
            for (int i = 0; i < dataBase.Customers.Count; i++)
            {
                dataBase.Customers[i].Id = i + 1;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Ви впевнені," +
                "що хочете видалити всіх клієнтів з таблиці?",
                "Підтвердження видалення", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                dataBase.Customers.Clear();
                UpdateCustomers();
                MessageBox.Show("Всі клієнти видалені");
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {

                int selectedCustomerId = (int)dgvCustomers.SelectedRows[0].Cells["dgvTxtId"].Value;
                var customerEdit = dataBase.Customers.FirstOrDefault(customer => customer.Id == selectedCustomerId);
                if (customerEdit != null)
                {
                    var editCustomerForm = new EditCustomerForm(customerEdit, dataBase);
                    editCustomerForm.ShowDialog();
                    UpdateCustomers();


                }
                else
                {
                    MessageBox.Show("Клієнта не знайдено");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка,виберіть клієнта для редагування");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = cmbSearch.SelectedItem?.ToString();
            string searchValue = txtSearch.Text;

            var filteredCustomers = dataBase.Customers.AsQueryable();

            if (!string.IsNullOrEmpty(filter) && !string.IsNullOrEmpty(searchValue))
            {
                switch (filter)
                {
                    case "Id":
                        if (int.TryParse(searchValue, out int id))
                        {
                            filteredCustomers = filteredCustomers.Where(c => c.Id == id);
                        }
                        break;
                    case "Ім'я":
                        filteredCustomers = filteredCustomers.Where(c => c.Name.Contains(searchValue, StringComparison.OrdinalIgnoreCase));
                        break;
                    case "Бюджет <=":
                        if (int.TryParse(searchValue, out int budget))
                        {
                            filteredCustomers = filteredCustomers.Where(c => c.Budget <= budget);
                        }
                        break;
                }
                dgvCustomers.Rows.Clear();
                foreach (var customer in filteredCustomers.ToList())
                {
                    dgvCustomers.Rows.Add(
                    customer.Id,
                    customer.Name,
                    customer.Number,
                    customer.PrefferedBrand,
                    customer.PrefferedYear,
                    customer.PrefferedCondition,
                    customer.Budget);
                }
            }
            
        }

        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSearch.SelectedIndex = -1;
            UpdateCustomers();
        }
        private void SaveFile()
        {
            dataBase.SaveFile(FilePath);

        }
        private void LoadFile()
        {
            dataBase.LoadFile(FilePath);
            UpdateCustomers();

        }
        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
            MessageBox.Show("Файл збережено");
        }
        private void loadFileMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
            MessageBox.Show("Файл загружено");
        }

    }
}
