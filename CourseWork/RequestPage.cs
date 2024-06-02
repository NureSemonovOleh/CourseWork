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
    public partial class RequestPage : Form
    {
        private DataBase dataBase;
        private CarsPage mainWindow;
        public RequestPage(DataBase dataBase, CarsPage mainWindow)
        {
            InitializeComponent();
            this.dataBase = dataBase;
            this.mainWindow = mainWindow;
            UpdateRequest();
        }

        private void UpdateRequest()
        {
            dgvRequests.Rows.Clear();
            foreach (var request in dataBase.Requests)
            {
                dgvRequests.Rows.Add(
                    request.Id,
                    request.CarId,
                    request.CustomerName,
                    request.CustomerNumber,
                    request.Status,
                    request.RequestDate);

            }
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {

            mainWindow.Show();
            this.Hide();
        }

        private void btnCustomerPage_Click(object sender, EventArgs e)
        {
            var customerPage = new CustomersPage(dataBase, mainWindow);
            customerPage.Show();
            this.Hide();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            var createRequestForm = new AddRequestForm(dataBase);
            createRequestForm.RequestAdded += CreateRequestForm_RequestAdded;
            createRequestForm.ShowDialog();
        }

        private void CreateRequestForm_RequestAdded(object? sender, EventArgs e)
        {
            UpdateRequest();
        }
    }
}
