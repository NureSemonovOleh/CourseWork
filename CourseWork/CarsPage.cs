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
        private void EditCarForm_CarEdited(object sender, EventArgs e)
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
            UpdateCarList();

        }
        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
            MessageBox.Show("Файл збережено");
        }
        private void loadFileMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
            MessageBox.Show("Файл загружено");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = cmbSearch.SelectedItem?.ToString();
            string searchValue = txtSearch.Text;
            var filteredCars = dataBase.Cars.AsQueryable();
            if (!string.IsNullOrEmpty(filter) && !string.IsNullOrEmpty(searchValue))
            {
                switch (filter)
                {
                    case "ID":
                        if (int.TryParse(searchValue, out int id))
                        {
                            filteredCars = filteredCars.Where(c => c.Id == id);
                        }
                        break;
                    case "Price <=":
                        if (int.TryParse(searchValue, out int price))
                        {
                            filteredCars = filteredCars.Where(c => c.Price <= price);
                        }
                        break;
                    case "Brand":
                        filteredCars = filteredCars.Where(c => c.Brand.Contains(searchValue, StringComparison.OrdinalIgnoreCase));
                        break;
                }
            }
            dgvCars.Rows.Clear();
            foreach (var car in filteredCars.ToList())
            {
                dgvCars.Rows.Add(
                    car.Id,
                    car.Brand,
                    car.Model,
                    car.Condition,
                    car.Year,
                    car.MaxSpeed,
                    car.EngineVolume,
                    car.Price);
            }

        }

        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSearch.SelectedIndex = -1;
            UpdateCarList();
        }
    }
}
