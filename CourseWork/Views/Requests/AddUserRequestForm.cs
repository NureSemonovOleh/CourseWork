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
    public partial class AddUserRequestForm : Form
    {
        private DataBase dataBase;
        private const string filePath = "database.json";

        public AddUserRequestForm(DataBase dataBase)
        {
            InitializeComponent();
            this.dataBase = dataBase;
            LoadCarList();
        }

        private void LoadCarList()
        {
            cmbCars.Items.Clear();
            foreach (var car in dataBase.Cars)
            {
                cmbCars.Items.Add($"{car.Id} - {car.Brand} {car.Model} ({car.Price})");
            }
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            if (cmbCars.SelectedItem == null || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.");
                return;
            }

            var selectedCarInfo = cmbCars.SelectedItem.ToString();
            var carId = int.Parse(selectedCarInfo.Split('-')[0].Trim());
            var car = dataBase.Cars.FirstOrDefault(c => c.Id == carId);

            var request = new Request
            {
                Id = dataBase.Requests.Count + 1,
                CarId = car.Id,
                CustomerName = txtName.Text,
                CustomerNumber = txtNumber.Text,
                Status = "В процесі",
                RequestDate = DateTime.Now
            };

            dataBase.Requests.Add(request);
            MessageBox.Show("Заявка додана, чекайте на дзвінок.");
            SaveFile();
            this.Close();
        }
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void SaveFile()
        {
            dataBase.SaveFile(filePath);
        }
    }
}
