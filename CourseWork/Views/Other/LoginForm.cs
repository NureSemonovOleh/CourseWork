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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnUserMode_Click(object sender, EventArgs e)
        {
            var carsPage = new CarsPage(false); 
            carsPage.Show();
            this.Hide();
        }
        private void btnAdminMode_Click(object sender, EventArgs e)
        {
            var carsPage = new CarsPage(true); 
            carsPage.Show();
            this.Hide();
        }
    }
}
