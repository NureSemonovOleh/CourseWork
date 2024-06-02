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
    public partial class AddRequestForm : Form
    {
        private DataBase dataBase;
        public event EventHandler RequestAdded;
        public AddRequestForm(DataBase dataBase)
        {
            InitializeComponent();
            this.dataBase = dataBase;
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            cmbCustomer.DataSource = dataBase.Customers;
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "Id";
        }
        private void LoadCars(Customer customer)
        {
            var neededCars = dataBase.Cars.Where(car =>
            (string.IsNullOrWhiteSpace(customer.PrefferedBrand) || car.Brand == customer.PrefferedBrand) &&
                car.Year >= customer.PrefferedYear &&
                car.Condition == customer.PrefferedCondition &&
                car.Price <= customer.Budget).ToList();
            cmbCars.DataSource = neededCars;
            cmbCars.DisplayMember = "Model";
            cmbCars.ValueMember = "Id";
        }
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex != -1)
            {
                var selectedCustomer = (Customer)cmbCustomer.SelectedItem;
                LoadCars(selectedCustomer);
            }
        }
        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            if (cmbCars.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a car.");
                return;
            }

            var selectedCustomer = (Customer)cmbCustomer.SelectedItem;
            var selectedCar = (Car)cmbCars.SelectedItem;

            var newRequest = new Request
            {
                Id = dataBase.Requests.Count > 0 ? dataBase.Requests.Max(r => r.Id) + 1 : 1,
                CarId = selectedCar.Id,
                CustomerName = selectedCustomer.Name,
                CustomerNumber = selectedCustomer.Number,
                Status = "В процессі",
                RequestDate = DateTime.Now
            };

            dataBase.Requests.Add(newRequest);
            MessageBox.Show("Заявка створена успішно.");
            RequestAdded?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
