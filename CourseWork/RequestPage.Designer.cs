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
            cmbSearch = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnSearchReset = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveFileMenuItem = new ToolStripMenuItem();
            SaveFileAsToolStripMenuItem = new ToolStripMenuItem();
            loadFileToolStripMenuItem = new ToolStripMenuItem();
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
            dgvRequests.TabStop = false;
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
            btnCustomerPage.TabIndex = 10;
            btnCustomerPage.Text = "Сторінка \"Покупці\"";
            btnCustomerPage.UseVisualStyleBackColor = true;
            btnCustomerPage.Click += btnCustomerPage_Click;
            // 
            // btnRequestPage
            // 
            btnRequestPage.Location = new Point(454, 449);
            btnRequestPage.Name = "btnRequestPage";
            btnRequestPage.Size = new Size(131, 29);
            btnRequestPage.TabIndex = 11;
            btnRequestPage.Text = "Сторінка \"Заявки\"";
            btnRequestPage.UseVisualStyleBackColor = true;
            btnRequestPage.Click += btnRequestPage_Click;
            // 
            // btnCarsPage
            // 
            btnCarsPage.Location = new Point(12, 449);
            btnCarsPage.Name = "btnCarsPage";
            btnCarsPage.Size = new Size(131, 29);
            btnCarsPage.TabIndex = 9;
            btnCarsPage.Text = "Сторінка \"Авто\"";
            btnCarsPage.UseVisualStyleBackColor = true;
            btnCarsPage.Click += btnMainPage_Click;
            // 
            // btnAddRequest
            // 
            btnAddRequest.Location = new Point(12, 319);
            btnAddRequest.Name = "btnAddRequest";
            btnAddRequest.Size = new Size(142, 42);
            btnAddRequest.TabIndex = 5;
            btnAddRequest.Text = "Додати заявку";
            btnAddRequest.UseVisualStyleBackColor = true;
            btnAddRequest.Click += btnAddRequest_Click;
            // 
            // btnDeleteRequest
            // 
            btnDeleteRequest.Location = new Point(213, 319);
            btnDeleteRequest.Name = "btnDeleteRequest";
            btnDeleteRequest.Size = new Size(142, 42);
            btnDeleteRequest.TabIndex = 6;
            btnDeleteRequest.Text = "Видалити заявку";
            btnDeleteRequest.UseVisualStyleBackColor = true;
            btnDeleteRequest.Click += btnDeleteRequest_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(404, 319);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(142, 42);
            btnDeleteAll.TabIndex = 7;
            btnDeleteAll.Text = "Видалити все";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Location = new Point(213, 367);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(142, 40);
            btnChangeStatus.TabIndex = 8;
            btnChangeStatus.Text = "Статус \"Готово\"";
            btnChangeStatus.UseVisualStyleBackColor = true;
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // cmbSearch
            // 
            cmbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Items.AddRange(new object[] { "ID", "Ім'я клієнта", "Статус" });
            cmbSearch.Location = new Point(12, 27);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(155, 23);
            cmbSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 56);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(118, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSearchReset
            // 
            btnSearchReset.Location = new Point(213, 27);
            btnSearchReset.Name = "btnSearchReset";
            btnSearchReset.Size = new Size(131, 52);
            btnSearchReset.TabIndex = 4;
            btnSearchReset.Text = "Прибрати фільтр";
            btnSearchReset.UseVisualStyleBackColor = true;
            btnSearchReset.Click += btnSearchReset_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(597, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveFileMenuItem, SaveFileAsToolStripMenuItem, loadFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // saveFileMenuItem
            // 
            saveFileMenuItem.Name = "saveFileMenuItem";
            saveFileMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            saveFileMenuItem.Size = new Size(255, 22);
            saveFileMenuItem.Text = "Зберегти файл";
            saveFileMenuItem.Click += saveFileMenuItem_Click;
            // 
            // SaveFileAsToolStripMenuItem
            // 
            SaveFileAsToolStripMenuItem.Name = "SaveFileAsToolStripMenuItem";
            SaveFileAsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Shift + S";
            SaveFileAsToolStripMenuItem.Size = new Size(255, 22);
            SaveFileAsToolStripMenuItem.Text = "Зберегти файл як";
            SaveFileAsToolStripMenuItem.Click += SaveFileAsToolStripMenuItem_Click;
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            loadFileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + L";
            loadFileToolStripMenuItem.Size = new Size(255, 22);
            loadFileToolStripMenuItem.Text = "Завантажити файл";
            loadFileToolStripMenuItem.Click += loadFileMenuItem_Click;
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
            aboutToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            aboutToolStripMenuItem.Size = new Size(198, 22);
            aboutToolStripMenuItem.Text = "Про програму";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // helpButtonsToolStripMenuItem
            // 
            helpButtonsToolStripMenuItem.Name = "helpButtonsToolStripMenuItem";
            helpButtonsToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            helpButtonsToolStripMenuItem.Size = new Size(198, 22);
            helpButtonsToolStripMenuItem.Text = "Допоміжні клавіші";
            helpButtonsToolStripMenuItem.Click += helpButtonsToolStripMenuItem_Click;
            // 
            // RequestPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 490);
            Controls.Add(menuStrip1);
            Controls.Add(btnSearchReset);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cmbSearch);
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
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RequestPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Менеджмент заявок";
            Load += RequestPage_Load;
            KeyDown += RequestPage_KeyDown;
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
        private ComboBox cmbSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnSearchReset;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveFileMenuItem;
        private ToolStripMenuItem SaveFileAsToolStripMenuItem;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpButtonsToolStripMenuItem;
    }
}