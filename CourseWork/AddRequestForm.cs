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
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
        }
        private void LoadCustomers()
        {
            var customerDisplayList = dataBase.Customers.Select(c => new
            {
                Display = $"{c.Id} - {c.Name} ({c.Number})",
                Value = c
            }).ToList();
            cmbCustomer.DataSource = customerDisplayList;
            cmbCustomer.DisplayMember = "Display";
            cmbCustomer.ValueMember = "Value";
        }
        private void LoadCars(Customer customer)
        {
            var neededCars = dataBase.Cars.Where(car =>
            (string.IsNullOrWhiteSpace(customer.PrefferedBrand) ||
            customer.PrefferedBrand == "Відсутня" ||
            car.Brand == customer.PrefferedBrand) &&
                car.Year >= customer.PrefferedYear &&
                car.Condition == customer.PrefferedCondition &&
                car.Price <= customer.Budget).Select
                (car => new {
                    Display = $"{car.Brand} {car.Model} ({car.Year}, {car.Condition})",
                    Value = car
                }).ToList();
            if (neededCars.Count == 0)
            {
                cmbCars.DataSource = new[] { new { Display = "Нема доступних авто", Value = (Car)null } };
                cmbCars.Enabled = false;
                
            }
            else
            {
                cmbCars.Enabled = true;
                cmbCars.DataSource = neededCars;
                cmbCars.DisplayMember = "Display";
                cmbCars.ValueMember = "Value";
            }

            
        }
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex != -1)
            {
                var selectedCustomer = (Customer)((dynamic)cmbCustomer.SelectedItem).Value;
                LoadCars(selectedCustomer);
            }
        }
        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Будь ласка,виберіть клієнта");
                return;
            }

            if (cmbCars.SelectedIndex == -1)
            {
                MessageBox.Show("Будь ласка,виберіть авто");
                return;
            }
            

            var selectedCustomer = (Customer)((dynamic)cmbCustomer.SelectedItem).Value;
            var selectedCar = (Car)((dynamic)cmbCars.SelectedItem).Value;

            if (selectedCar == null)
            {
                MessageBox.Show("Нема доступних авто для цього клієнта.");
                return;
            }
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
