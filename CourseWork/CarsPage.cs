namespace CourseWork
{
    public partial class CarsPage : Form
    {

        private DataBase dataBase;
        private const string FilePath = "database.json";

        public CarsPage()
        {
            InitializeComponent();
            dataBase = new DataBase();
            LoadFile();

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
        private void UpdateCarList()
        {
            dgvCars.Rows.Clear();
            foreach (var car in dataBase.Cars)
            {
                dgvCars.Rows.Add(car.Id,
                    car.Brand,
                    car.Model,
                    car.Condition,
                    car.Year,
                    car.MaxSpeed,
                    car.EngineVolume,
                    car.Price);
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var addCarForm = new AddCarForm(dataBase);
            addCarForm.CarAdded += AddCarForm_CarAdded;
            addCarForm.ShowDialog();
        }
        private void AddCarForm_CarAdded(object sender, EventArgs e)
        {
            UpdateCarList();
        }
        private void btnEditCar_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0)
            {
                int selectedCarId = (int)dgvCars.SelectedRows[0].Cells["dgvTxtColumnId"].Value;
                var carEdit = dataBase.Cars.FirstOrDefault(car => car.Id == selectedCarId);
                if (carEdit != null)
                {
                    var editCarForm = new EditCarForm(dataBase, carEdit);
                    editCarForm.CarEdited += EditCarForm_CarEdited;
                    editCarForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Авто не знайдене");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть авто для редагування");
            }
        }
        private void EditCarForm_CarEdited (object sender, EventArgs e)
        {
            UpdateCarList();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Ви впевнені,що хочете видалити це авто?", "Підтвердження видалення",
                    MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    int selectedCarId = (int)dgvCars.SelectedRows[0].Cells["dgvTxtColumnId"].Value;
                    var carRemove = dataBase.Cars.FirstOrDefault(car => car.Id == selectedCarId);
                    if (carRemove != null)
                    {
                        dataBase.Cars.Remove(carRemove);
                        RecalcId();
                        UpdateCarList();
                        MessageBox.Show("Авто видалене успішно");
                    }
                    else
                    {
                        MessageBox.Show("Авто не знайдене");
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка,виберіть авто для видалення");
            }

        }
        private void RecalcId()
        {
            for (int i = 0; i < dataBase.Cars.Count; i++)
            {
                dataBase.Cars[i].Id = i + 1;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Ви впевнені," +
                "що хочете видалити всі авто з таблиці?",
                "Підтвердження видалення", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                dataBase.Cars.Clear();
                UpdateCarList();
                MessageBox.Show("Всі автомобілі видалені");
            }
        }
        private void SaveFile()
        {
            dataBase.SaveFile(FilePath);
            
        }
        private void LoadFile()
        {
            dataBase.LoadFile(FilePath);
            UpdateCarList() ;
            
        }
        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
            MessageBox.Show("data saved");
        }
        private void loadFileMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
            MessageBox.Show("data loaded");
        }

        private void btnCustomerPage_Click(object sender, EventArgs e)
        {
            var customerPage = new CustomersPage(dataBase, this);
            this.Hide();
            customerPage.Show();
            
            
        }

        private void btnRequestPage_Click(object sender, EventArgs e)
        {
            var requestPage = new RequestPage(dataBase, this);
            this.Hide();
            requestPage.Show();
        }

        

        


        /*private void ApplySearchFilter()
        {
            var searchTerm = txtSearch.Text.ToLower();
            var searchType = cmbSearch.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(searchTerm) || string.IsNullOrEmpty(searchType))
            {
                dgvCars.DataSource = dataBase.Cars;
                return;
            }

            switch (searchType)
            {
                case "ID":
                    if (int.TryParse(searchTerm, out int id))
                    {
                        dgvCars.DataSource = dataBase.Cars.Where(car => car.Id == id).ToList();
                    }
                    break;
                case "Brand":
                    dgvCars.DataSource = dataBase.Cars.Where(car => car.Brand.ToLower().Contains(searchTerm)).ToList();
                    break;
                case "Price <= ":
                    if (int.TryParse(searchTerm, out int price))
                    {
                        dgvCars.DataSource = dataBase.Cars.Where(car => car.Price <= price).ToList();
                    }
                    break;
                case "Condition":
                    dgvCars.DataSource = dataBase.Cars.Where(car => car.Condition.ToLower().Contains(searchTerm)).ToList();
                    break;
                default:
                    dgvCars.DataSource = dataBase.Cars;
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearchReset_Click(object sender, EventArgs e)
        {

        }*/
    }
}
