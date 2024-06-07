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
    public partial class EditCarForm : Form
    {
        private DataBase dataBase;
        private Car carToEdit;
        
        public event EventHandler CarEdited;
        public EditCarForm(DataBase database, Car car)
        {
           
            InitializeComponent();
            dataBase = database;
            carToEdit = car;
            LoadData();


        }
        
        private void LoadData()
        {
            cmbBrand.Items.AddRange(dataBase.carModels.Keys.ToArray());
            cmbBrand.Text = carToEdit.Brand;
            cmbModels.Text = carToEdit.Model;
            cmbCondition.Text = carToEdit.Condition;
            txtYear.Text = carToEdit.Year.ToString();
            txtMaxSpeed.Text = carToEdit.MaxSpeed.ToString();
            txtEngineVolume.Text = carToEdit.EngineVolume.ToString();
            txtPrice.Text = carToEdit.Price.ToString();
        }
        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrand.SelectedItem != null)
            {
                var selectedBrand = cmbBrand.SelectedItem.ToString();
                cmbModels.Items.Clear();
                cmbModels.Items.AddRange(dataBase.carModels[selectedBrand].ToArray());
            }
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cmbBrand.Text))
                {
                    MessageBox.Show("Будь ласка,виберіть вірну марку.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cmbModels.Text))
                {
                    MessageBox.Show("Будь ласка, виберіть вірну модель");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cmbCondition.Text))
                {
                    MessageBox.Show("Будь ласка, вкажіть стан авто");
                    return;
                }
                if (!int.TryParse(txtYear.Text, out int year) || string.IsNullOrWhiteSpace(txtYear.Text))
                {
                    MessageBox.Show("Будь ласка, вкажіть вірний рік.");
                    return;
                }
                if (!int.TryParse(txtMaxSpeed.Text, out int maxSpeed))
                {
                    MessageBox.Show("Будь ласка,вкажіть вірну швидкість");
                    return;
                }
                if (!decimal.TryParse(txtEngineVolume.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal engineVolume))
                {
                    MessageBox.Show("Будь ласка, вкажіть вірний об'єм двигуну.");
                    return;
                }
                if (!int.TryParse(txtPrice.Text, out int price))
                {
                    MessageBox.Show("Будь ласка, вкажіть вірну ціну.");
                    return;
                }
                carToEdit.Brand = cmbBrand.Text;
                carToEdit.Model = cmbModels.Text;
                carToEdit.Condition = cmbCondition.Text;
                carToEdit.Year = int.Parse(txtYear.Text);
                carToEdit.MaxSpeed = int.Parse(txtMaxSpeed.Text);
                carToEdit.EngineVolume = decimal.Parse(txtEngineVolume.Text);
                carToEdit.Price = int.Parse(txtPrice.Text);

                CarEdited?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error editing car: {ex.Message}");
            }
        }
        private void txtEngineVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }

        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtMaxSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
