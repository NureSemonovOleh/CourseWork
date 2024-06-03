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
        }
        private void RequestPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) {
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
        private void SaveFile()
        {
            dataBase.SaveFile(FilePath);

        }
        private void LoadFile()
        {
            dataBase.LoadFile(FilePath);
            UpdateRequest();

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
    }

}
