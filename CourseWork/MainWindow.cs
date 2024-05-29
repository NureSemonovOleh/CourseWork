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
            lstCars.Items.Clear();
            foreach(var car in dataBase.Cars)
            {
                lstCars.Items.Add($"{car.Id} {car.Brand} {car.Model} " +
                    $"{car.Condition} {car.Year}" +
                    $" {car.MaxSpeed} {car.EngineVolume} {car.Price}");
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
    }
}
