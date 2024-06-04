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
    public partial class RequestPage : Form
    {
        private DataBase dataBase;
        private CarsPage mainWindow;
        private const string FilePath = "database.json";
        public RequestPage(DataBase dataBase, CarsPage mainWindow)
        {
            InitializeComponent();
            this.dataBase = dataBase;
            this.mainWindow = mainWindow;
            UpdateRequest();
            FormClosing += RequestPage_FormClosing;
            dataBase.DataLoaded += DataBase_DataLoaded;
        }
        private void RequestPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void DataBase_DataLoaded(object sender, EventArgs e)
        {
            UpdateRequest();
        }
        private void UpdateRequest()
        {
            dgvRequests.Rows.Clear();
            foreach (var request in dataBase.Requests)
            {
                dgvRequests.Rows.Add(
                    request.Id,
                    request.CarId,
                    request.CustomerName,
                    request.CustomerNumber,
                    request.Status,
                    request.RequestDate);

            }
        }
        private void RecalcId()
        {
            for (int i = 0; i < dataBase.Requests.Count; i++)
            {
                dataBase.Requests[i].Id = i + 1;
            }
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {

            mainWindow.Show();
            this.Hide();
        }

        private void btnCustomerPage_Click(object sender, EventArgs e)
        {
            var customerPage = new CustomersPage(dataBase, mainWindow);
            customerPage.Show();
            this.Hide();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            var createRequestForm = new AddRequestForm(dataBase);
            createRequestForm.RequestAdded += CreateRequestForm_RequestAdded;
            createRequestForm.ShowDialog();
        }

        private void CreateRequestForm_RequestAdded(object? sender, EventArgs e)
        {
            UpdateRequest();
        }
        private void CustomerPage_CustomerEdited(object sender, EventArgs e)
        {
            UpdateRequest();
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            if (dgvRequests.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Ви впевнені, що хочете видалити цю заявку?",
                    "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int selectedRequestId = (int)dgvRequests.SelectedRows[0].Cells["Id"].Value;
                    var requestRemove = dataBase.Requests.FirstOrDefault(r => r.Id == selectedRequestId);
                    if (requestRemove != null)
                    {
                        dataBase.Requests.Remove(requestRemove);
                        RecalcId();
                        UpdateRequest();

                        MessageBox.Show("Заявку видалено успішно.");
                    }
                    else
                    {
                        MessageBox.Show("Заявку не знайдено.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть заявку для видалення.");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені,що хочете видалити всі заявки?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                dataBase.Requests.Clear();
                UpdateRequest();
                MessageBox.Show("Всі заявки видалені успішно");
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (dgvRequests.SelectedRows.Count > 0)
            {
                int selectedRequestId = (int)dgvRequests.SelectedRows[0].Cells["Id"].Value;
                var requestToChange = dataBase.Requests.FirstOrDefault(r => r.Id == selectedRequestId);
                if (requestToChange != null)
                {
                    var result = MessageBox.Show("Ви впевнені,що хочете змінити статус заявки?",
                    "Підтвердження змінення",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        requestToChange.Status = "Готово";
                        UpdateRequest();
                        MessageBox.Show("Статус заявки змінено успішно");
                    }
                }
                else
                {
                    MessageBox.Show("Заявку не знайдено.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть заявку для зміни статусу.");
            }
        }
        private void SaveFile(string filePath)
        {
            dataBase.SaveFile(filePath);

        }
        private void LoadFile(string filePath)
        {
            dataBase.LoadFile(filePath);

            UpdateRequest();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = cmbSearch.SelectedItem?.ToString();
            string searchValue = txtSearch.Text;

            var filteredRequests = dataBase.Requests.AsQueryable();

            if (!string.IsNullOrEmpty(filter) && !string.IsNullOrEmpty(searchValue))
            {
                switch (filter)
                {
                    case "ID":
                        if (int.TryParse(searchValue, out int id))
                        {
                            filteredRequests = filteredRequests.Where(c => c.Id == id);
                        }
                        break;
                    case "Ім'я клієнта":
                        filteredRequests = filteredRequests.Where(c => c.CustomerName.Contains(searchValue, StringComparison.OrdinalIgnoreCase));
                        break;
                    case "Статус":


                        filteredRequests = filteredRequests.Where(r => r.Status.Contains(searchValue, StringComparison.OrdinalIgnoreCase));

                        break;
                }
                dgvRequests.Rows.Clear();
                foreach (var request in filteredRequests.ToList())
                {
                    dgvRequests.Rows.Add(
                    request.Id,
                    request.CarId,
                    request.CustomerName,
                    request.CustomerNumber,
                    request.Status,
                    request.RequestDate);
                }
            }
        }

        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSearch.SelectedIndex = -1;
            UpdateRequest();
        }
        private void RequestPage_KeyDown(object sender, KeyEventArgs e)
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
        private void RequestPage_Load(object sender, EventArgs e)
        {
            dgvRequests.ClearSelection();
        }

        private void btnRequestPage_Click(object sender, EventArgs e)
        {

        }
    }

}
