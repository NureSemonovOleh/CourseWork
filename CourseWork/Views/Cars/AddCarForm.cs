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

    public partial class AddCarForm : Form
    {
        private DataBase dataBase;
       
        public event EventHandler CarAdded;
        public AddCarForm(DataBase database)
        {

            InitializeComponent();
            dataBase = database;
            InitializeForm();
            

        }
        
        private void InitializeForm()
        {
            cmbBrand.Items.AddRange(dataBase.carModels.Keys.ToArray());
            cmbBrand.SelectedIndexChanged += CmbBrand_SelectedIndexChanged;
            cmbBrand.SelectedIndex = 0;
            UpdateModels();
            cmbCondition.Items.AddRange(new string[] { "New", "Old", "Crashed" });
        }

        private void CmbBrand_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateModels();
        }

        private void UpdateModels()
        {
            cmbModels.Items.Clear();
            string selectedBrand = cmbBrand.SelectedItem.ToString();
            if (dataBase.carModels.ContainsKey(selectedBrand))
            {
                cmbModels.Items.AddRange(dataBase.carModels[selectedBrand].ToArray());
            }
            cmbModels.SelectedIndex = 0;
        }
        

        private void cmbModels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAddCar_Click(object sender, EventArgs e)
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


                var car = new Car
                {
                    Id = dataBase.Cars.Count > 0 ? dataBase.Cars.Max(x => x.Id) + 1 : 1,
                    Brand = cmbBrand.SelectedItem.ToString(),
                    Model = cmbModels.SelectedItem.ToString(),
                    Condition = cmbCondition.SelectedItem.ToString(),
                    Year = int.Parse(txtYear.Text),
                    MaxSpeed = int.Parse(txtMaxSpeed.Text),
                    EngineVolume = decimal.Parse(txtEngineVolume.Text),
                    Price = int.Parse(txtPrice.Text)
                };
                dataBase.Cars.Add(car);
                CarAdded?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (FormatException ex) {
                MessageBox.Show($"Error parsing input: {ex.Message}");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding car:{ex.Message}");
            }

            
        }
        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEngineVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ','){
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
        
    }

}
