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
        private MainWindow mainWindow;
        public CustomersPage(DataBase database, MainWindow mainwindow)
        {
            InitializeComponent();
            dataBase = database;
            mainWindow = mainwindow;
           
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }
        private void btnRequestPage_Click(object sender, EventArgs e)
        {
            var requestPage = new RequestPage(dataBase, this);
            this.Hide();
            requestPage.Show();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
        }
        private void AddCustomerForm_CustomerAdded(object sender, EventArgs e)
        {
           
        }
    }
}
