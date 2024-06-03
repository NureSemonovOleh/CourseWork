namespace CourseWork
{
    partial class RequestPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestPage));
            dgvRequests = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CarId = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            CustomerNumber = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            RequestDate = new DataGridViewTextBoxColumn();
            btnCustomerPage = new Button();
            btnRequestPage = new Button();
            btnCarsPage = new Button();
            btnAddRequest = new Button();
            btnDeleteRequest = new Button();
            btnDeleteAll = new Button();
            btnChangeStatus = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveFileMenuItem = new ToolStripMenuItem();
            loadFileToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            addCarToolStripMenuItem = new ToolStripMenuItem();
            addCustomerToolStripMenuItem = new ToolStripMenuItem();
            оформитиЗаявкуToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            helpButtonsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRequests
            // 
            dgvRequests.AllowUserToAddRows = false;
            dgvRequests.AllowUserToDeleteRows = false;
            dgvRequests.AllowUserToResizeColumns = false;
            dgvRequests.AllowUserToResizeRows = false;
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Columns.AddRange(new DataGridViewColumn[] { Id, CarId, CustomerName, CustomerNumber, Status, RequestDate });
            dgvRequests.Location = new Point(12, 148);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.Size = new Size(534, 150);
            dgvRequests.TabIndex = 0;
            dgvRequests.UseWaitCursor = true;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MaxInputLength = 3;
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // CarId
            // 
            CarId.HeaderText = "CarID";
            CarId.MaxInputLength = 3;
            CarId.Name = "CarId";
            CarId.Width = 50;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Ім'я клієнта";
            CustomerName.Name = "CustomerName";
            CustomerName.Width = 120;
            // 
            // CustomerNumber
            // 
            CustomerNumber.HeaderText = "Номер клієнта";
            CustomerNumber.MaxInputLength = 10;
            CustomerNumber.Name = "CustomerNumber";
            CustomerNumber.Width = 90;
            // 
            // Status
            // 
            Status.HeaderText = "Статус";
            Status.Name = "Status";
            Status.Width = 60;
            // 
            // RequestDate
            // 
            RequestDate.HeaderText = "Дата";
            RequestDate.Name = "RequestDate";
            RequestDate.Width = 120;
            // 
            // btnCustomerPage
            // 
            btnCustomerPage.Location = new Point(224, 449);
            btnCustomerPage.Name = "btnCustomerPage";
            btnCustomerPage.Size = new Size(131, 29);
            btnCustomerPage.TabIndex = 5;
            btnCustomerPage.Text = "Сторінка \"Покупці\"";
            btnCustomerPage.UseVisualStyleBackColor = true;
            btnCustomerPage.UseWaitCursor = true;
            btnCustomerPage.Click += btnCustomerPage_Click;
            // 
            // btnRequestPage
            // 
            btnRequestPage.Location = new Point(454, 449);
            btnRequestPage.Name = "btnRequestPage";
            btnRequestPage.Size = new Size(131, 29);
            btnRequestPage.TabIndex = 7;
            btnRequestPage.Text = "Сторінка \"Заявки\"";
            btnRequestPage.UseVisualStyleBackColor = true;
            btnRequestPage.UseWaitCursor = true;
            // 
            // btnCarsPage
            // 
            btnCarsPage.Location = new Point(12, 449);
            btnCarsPage.Name = "btnCarsPage";
            btnCarsPage.Size = new Size(131, 29);
            btnCarsPage.TabIndex = 8;
            btnCarsPage.Text = "Сторінка \"Авто\"";
            btnCarsPage.UseVisualStyleBackColor = true;
            btnCarsPage.UseWaitCursor = true;
            btnCarsPage.Click += btnMainPage_Click;
            // 
            // btnAddRequest
            // 
            btnAddRequest.Location = new Point(12, 319);
            btnAddRequest.Name = "btnAddRequest";
            btnAddRequest.Size = new Size(142, 42);
            btnAddRequest.TabIndex = 10;
            btnAddRequest.Text = "Додати заявку";
            btnAddRequest.UseVisualStyleBackColor = true;
            btnAddRequest.UseWaitCursor = true;
            btnAddRequest.Click += btnAddRequest_Click;
            // 
            // btnDeleteRequest
            // 
            btnDeleteRequest.Location = new Point(213, 319);
            btnDeleteRequest.Name = "btnDeleteRequest";
            btnDeleteRequest.Size = new Size(142, 42);
            btnDeleteRequest.TabIndex = 11;
            btnDeleteRequest.Text = "Видалити заявку";
            btnDeleteRequest.UseVisualStyleBackColor = true;
            btnDeleteRequest.UseWaitCursor = true;
            btnDeleteRequest.Click += btnDeleteRequest_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(404, 319);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(142, 42);
            btnDeleteAll.TabIndex = 12;
            btnDeleteAll.Text = "Видалити все";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.UseWaitCursor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Location = new Point(213, 367);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(142, 40);
            btnChangeStatus.TabIndex = 13;
            btnChangeStatus.Text = "Статус \"Готово\"";
            btnChangeStatus.UseVisualStyleBackColor = true;
            btnChangeStatus.UseWaitCursor = true;
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, manageToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(597, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.UseWaitCursor = true;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveFileMenuItem, loadFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // saveFileMenuItem
            // 
            saveFileMenuItem.Name = "saveFileMenuItem";
            saveFileMenuItem.Size = new Size(177, 22);
            saveFileMenuItem.Text = "Зберегти файл";
            saveFileMenuItem.Click += saveFileMenuItem_Click;
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            loadFileToolStripMenuItem.Size = new Size(177, 22);
            loadFileToolStripMenuItem.Text = "Завантажити файл";
            loadFileToolStripMenuItem.Click += loadFileMenuItem_Click;
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCarToolStripMenuItem, addCustomerToolStripMenuItem, оформитиЗаявкуToolStripMenuItem });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(77, 20);
            manageToolStripMenuItem.Text = "Керування";
            // 
            // addCarToolStripMenuItem
            // 
            addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            addCarToolStripMenuItem.Size = new Size(172, 22);
            addCarToolStripMenuItem.Text = "Додати авто";
            // 
            // addCustomerToolStripMenuItem
            // 
            addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            addCustomerToolStripMenuItem.Size = new Size(172, 22);
            addCustomerToolStripMenuItem.Text = "Додати покупця";
            // 
            // оформитиЗаявкуToolStripMenuItem
            // 
            оформитиЗаявкуToolStripMenuItem.Name = "оформитиЗаявкуToolStripMenuItem";
            оформитиЗаявкуToolStripMenuItem.Size = new Size(172, 22);
            оформитиЗаявкуToolStripMenuItem.Text = "Оформити заявку";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, helpButtonsToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(75, 20);
            helpToolStripMenuItem.Text = "Допомога";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(179, 22);
            aboutToolStripMenuItem.Text = "Про програму";
            // 
            // helpButtonsToolStripMenuItem
            // 
            helpButtonsToolStripMenuItem.Name = "helpButtonsToolStripMenuItem";
            helpButtonsToolStripMenuItem.Size = new Size(179, 22);
            helpButtonsToolStripMenuItem.Text = "Допоміжні клавіші";
            // 
            // RequestPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 490);
            Controls.Add(menuStrip1);
            Controls.Add(btnChangeStatus);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDeleteRequest);
            Controls.Add(btnAddRequest);
            Controls.Add(btnCarsPage);
            Controls.Add(btnRequestPage);
            Controls.Add(btnCustomerPage);
            Controls.Add(dgvRequests);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RequestPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Менедж заявок";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRequests;
        private Button btnCustomerPage;
        private Button btnRequestPage;
        private Button btnCarsPage;
        private Button btnAddRequest;
        private Button btnDeleteRequest;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CarId;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CustomerNumber;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn RequestDate;
        private Button btnDeleteAll;
        private Button btnChangeStatus;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveFileMenuItem;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem addCarToolStripMenuItem;
        private ToolStripMenuItem addCustomerToolStripMenuItem;
        private ToolStripMenuItem оформитиЗаявкуToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpButtonsToolStripMenuItem;
    }
}