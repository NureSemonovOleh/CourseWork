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
            dgvRequests = new DataGridView();
            btnCustomerPage = new Button();
            btnRequestPage = new Button();
            btnMainPage = new Button();
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
            btnAddRequest = new Button();
            Id = new DataGridViewTextBoxColumn();
            CarId = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            CustomerNumber = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            RequestDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRequests
            // 
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Columns.AddRange(new DataGridViewColumn[] { Id, CarId, CustomerName, CustomerNumber, Status, RequestDate });
            dgvRequests.Location = new Point(12, 148);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.Size = new Size(478, 150);
            dgvRequests.TabIndex = 0;
            // 
            // btnCustomerPage
            // 
            btnCustomerPage.Location = new Point(241, 449);
            btnCustomerPage.Name = "btnCustomerPage";
            btnCustomerPage.Size = new Size(131, 29);
            btnCustomerPage.TabIndex = 5;
            btnCustomerPage.Text = "Сторінка \"Покупці\"";
            btnCustomerPage.UseVisualStyleBackColor = true;
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
            // 
            // btnMainPage
            // 
            btnMainPage.Location = new Point(12, 449);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(131, 29);
            btnMainPage.TabIndex = 8;
            btnMainPage.Text = "Сторінка \"Авто\"";
            btnMainPage.UseVisualStyleBackColor = true;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, manageToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(597, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
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
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            loadFileToolStripMenuItem.Size = new Size(177, 22);
            loadFileToolStripMenuItem.Text = "Завантажити файл";
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
            // btnAddRequest
            // 
            btnAddRequest.Location = new Point(12, 319);
            btnAddRequest.Name = "btnAddRequest";
            btnAddRequest.Size = new Size(142, 42);
            btnAddRequest.TabIndex = 10;
            btnAddRequest.Text = "Додати заявку";
            btnAddRequest.UseVisualStyleBackColor = true;
            btnAddRequest.Click += btnAddRequest_Click;
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
            CustomerName.HeaderText = "Customer Name";
            CustomerName.Name = "CustomerName";
            // 
            // CustomerNumber
            // 
            CustomerNumber.HeaderText = "Customer Number";
            CustomerNumber.MaxInputLength = 10;
            CustomerNumber.Name = "CustomerNumber";
            CustomerNumber.Width = 75;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Width = 60;
            // 
            // RequestDate
            // 
            RequestDate.HeaderText = "Date";
            RequestDate.Name = "RequestDate";
            // 
            // RequestPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 490);
            Controls.Add(btnAddRequest);
            Controls.Add(menuStrip1);
            Controls.Add(btnMainPage);
            Controls.Add(btnRequestPage);
            Controls.Add(btnCustomerPage);
            Controls.Add(dgvRequests);
            Name = "RequestPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
        private Button btnMainPage;
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
        private Button btnAddRequest;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CarId;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CustomerNumber;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn RequestDate;
    }
}