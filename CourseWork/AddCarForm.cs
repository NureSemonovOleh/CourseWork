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

    public partial class AddCarForm : Form
    {
        private DataBase dataBase;
        private Dictionary<string, List<string>> carModels;
        public event EventHandler CarAdded;
        public AddCarForm(DataBase database)
        {
            InitializeCarModels();
            InitializeComponent();
            InitializeForm();
            dataBase = database;

        }
        private void InitializeCarModels()
        {
            carModels = new Dictionary<string, List<string>>
            {
                {"Toyota", new List<string> {"Supra","Corolla","Chaser"} },
                {"Nissan", new List<string>{"Skyline","240sx","350z"} },
                {"Ford", new List<string>{"Mustang", "GT", "Focus"} }
            };

        }
        private void InitializeForm()
        {
            cmbBrand.Items.AddRange(carModels.Keys.ToArray());
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
            if (carModels.ContainsKey(selectedBrand))
            {
                cmbModels.Items.AddRange(carModels[selectedBrand].ToArray());
            }
            cmbModels.SelectedIndex = 0;
        }
        

        private void cmbModels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var car = new Car
            {
                Id = dataBase.Cars.Count > 0 ? dataBase.Cars.Max(x => x.Id) + 1 : 1,
                Brand = cmbBrand.SelectedItem.ToString(),
                Model = cmbModels.SelectedItem.ToString(),
                Year = int.Parse(txtYear.Text),
                MaxSpeed = int.Parse(txtMaxSpeed.Text),
                EngineVolume = decimal.Parse(txtEngineVolume.Text),
                Price = int.Parse(txtPrice.Text)
            };
            dataBase.Cars.Add(car);
            CarAdded?.Invoke(this, EventArgs.Empty);
            this.Close();
            
        }
    }

}
