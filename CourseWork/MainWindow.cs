namespace CourseWork
{
    public partial class MainWindow : Form
    {

        private DataBase dataBase = new DataBase();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
        private void UpdateCarList()
        {
            dgvCars.Rows.Clear();
            foreach (var car in dataBase.Cars)
            {
                dgvCars.Rows.Add(car.Id, car.Brand, car.Model, car.Condition, car.Year,
                    car.MaxSpeed, car.EngineVolume, car.Price);
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
        private async void SaveFile()
        {
            string filePath = "dataBase.json";
            try
            {
                await dataBase.Save(filePath);
                MessageBox.Show("Data saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void LoadFile()
        {
            string filePath = "dataBase.json";
            try
            {
                dataBase = await DataBase.Load(filePath);
                MessageBox.Show("Data loaded");
                UpdateCarList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

       
    }
}
