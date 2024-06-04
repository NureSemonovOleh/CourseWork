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
            dataBase.DataLoaded += DataBase_DataLoaded;
            LoadFile(FilePath);

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            dgvCars.ClearSelection();
        }
        private void DataBase_DataLoaded(object sender, EventArgs e)
        {
            UpdateCarList();
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
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                dataBase.Cars.Clear();
                UpdateCarList();
                MessageBox.Show("Всі автомобілі видалені");
            }
        }
        private void SaveFile(string filePath)
        {
            dataBase.SaveFile(filePath);

        }
        private void LoadFile(string filePath)
        {
            dataBase.LoadFile(filePath);
            UpdateCarList();
        }
        private void LoadFileAs()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON файли (*.json)|*.json|Всі файли (*.*)|*.*",
                Title = "Відкрити файл"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadFile(openFileDialog.FileName);
                
               
                MessageBox.Show("Файл завантажено");
            }

        }
        private void SaveFileAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON файлы (*.json)|*.json|Все файлы (*.*)|*.*",
                Title = "Зберегти як"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveFileDialog.FileName);
                MessageBox.Show("Файл збережено");
            }
        }
        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(FilePath);
            
        }
        private void loadFileMenuItem_Click(object sender, EventArgs e)
        {
            LoadFileAs();
        }
        private void SaveFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutProgram = new AboutProgramForm();
            aboutProgram.ShowDialog();
        }

       

        private void helpButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var helpfulButtons = new HelpfulKeysForm();
            helpfulButtons.ShowDialog();
        }
        private void CarsPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                HelpfulKeysForm helpfulKeysForm = new HelpfulKeysForm();
                helpfulKeysForm.ShowDialog();
            }
            else if (e.KeyCode == Keys.F2)
            {
               AboutProgramForm aboutProgramForm = new AboutProgramForm();
                aboutProgramForm.ShowDialog();
            }
            else if (e.Control && e.KeyCode == Keys.S && !e.Shift)
            {
                SaveFile(FilePath);
                MessageBox.Show("Файл збережено");
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                SaveFileAs();
            }
            else if (e.Control && e.KeyCode == Keys.L)
            {
                LoadFileAs();
            }
        }
    }
}
