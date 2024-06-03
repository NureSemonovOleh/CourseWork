using System.Windows.Forms;

namespace CourseWork
{
    partial class CustomersPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersPage));
            dgvCustomers = new DataGridView();
            dgvTxtId = new DataGridViewTextBoxColumn();
            dgvTxtColumnName = new DataGridViewTextBoxColumn();
            dgvTxtColumnNumber = new DataGridViewTextBoxColumn();
            dgvTxtColumnPrefferedBrand = new DataGridViewTextBoxColumn();
            dgvTxtColumnPrefferedCondition = new DataGridViewTextBoxColumn();
            dgvTxtColumnPrefferedYear = new DataGridViewTextBoxColumn();
            dgvTxtColumnBudget = new DataGridViewTextBoxColumn();
            btnAddNew = new Button();
            btnDeleteCustomer = new Button();
            btnDeleteAll = new Button();
            btnEditCustomer = new Button();
            btnMainPage = new Button();
            btnCustomerPage = new Button();
            btnRequestPage = new Button();
            cmbSearch = new ComboBox();
            btnSearchReset = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { dgvTxtId, dgvTxtColumnName, dgvTxtColumnNumber, dgvTxtColumnPrefferedBrand, dgvTxtColumnPrefferedCondition, dgvTxtColumnPrefferedYear, dgvTxtColumnBudget });
            dgvCustomers.Location = new Point(12, 114);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ScrollBars = ScrollBars.Vertical;
            dgvCustomers.Size = new Size(553, 206);
            dgvCustomers.TabIndex = 0;
            // 
            // dgvTxtId
            // 
            dgvTxtId.HeaderText = "ID";
            dgvTxtId.MaxInputLength = 3;
            dgvTxtId.Name = "dgvTxtId";
            dgvTxtId.Width = 50;
            // 
            // dgvTxtColumnName
            // 
            dgvTxtColumnName.HeaderText = "Ім'я";
            dgvTxtColumnName.Name = "dgvTxtColumnName";
            dgvTxtColumnName.ReadOnly = true;
            dgvTxtColumnName.Width = 85;
            // 
            // dgvTxtColumnNumber
            // 
            dgvTxtColumnNumber.HeaderText = "Номер телефону";
            dgvTxtColumnNumber.MaxInputLength = 10;
            dgvTxtColumnNumber.Name = "dgvTxtColumnNumber";
            dgvTxtColumnNumber.ReadOnly = true;
            dgvTxtColumnNumber.Width = 80;
            // 
            // dgvTxtColumnPrefferedBrand
            // 
            dgvTxtColumnPrefferedBrand.HeaderText = "Бажана марка";
            dgvTxtColumnPrefferedBrand.Name = "dgvTxtColumnPrefferedBrand";
            dgvTxtColumnPrefferedBrand.ReadOnly = true;
            dgvTxtColumnPrefferedBrand.Width = 80;
            // 
            // dgvTxtColumnPrefferedCondition
            // 
            dgvTxtColumnPrefferedCondition.HeaderText = "Бажаний стан";
            dgvTxtColumnPrefferedCondition.Name = "dgvTxtColumnPrefferedCondition";
            dgvTxtColumnPrefferedCondition.ReadOnly = true;
            dgvTxtColumnPrefferedCondition.Width = 65;
            // 
            // dgvTxtColumnPrefferedYear
            // 
            dgvTxtColumnPrefferedYear.HeaderText = "Бажано від ... року";
            dgvTxtColumnPrefferedYear.MaxInputLength = 4;
            dgvTxtColumnPrefferedYear.Name = "dgvTxtColumnPrefferedYear";
            dgvTxtColumnPrefferedYear.ReadOnly = true;
            dgvTxtColumnPrefferedYear.Width = 75;
            // 
            // dgvTxtColumnBudget
            // 
            dgvTxtColumnBudget.HeaderText = "Бюджет";
            dgvTxtColumnBudget.MaxInputLength = 8;
            dgvTxtColumnBudget.Name = "dgvTxtColumnBudget";
            dgvTxtColumnBudget.ReadOnly = true;
            dgvTxtColumnBudget.Width = 75;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(12, 326);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(131, 55);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Додати покупця";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(232, 327);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(131, 55);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "Видалити покупця";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(434, 327);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(131, 55);
            btnDeleteAll.TabIndex = 3;
            btnDeleteAll.Text = "Видалити всіх";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new Point(232, 388);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(131, 55);
            btnEditCustomer.TabIndex = 4;
            btnEditCustomer.Text = "Редагувати покупця";
            btnEditCustomer.UseVisualStyleBackColor = true;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // btnMainPage
            // 
            btnMainPage.Location = new Point(12, 449);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(131, 29);
            btnMainPage.TabIndex = 5;
            btnMainPage.Text = "Сторінка \"Авто\"";
            btnMainPage.UseVisualStyleBackColor = true;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // btnCustomerPage
            // 
            btnCustomerPage.Location = new Point(232, 449);
            btnCustomerPage.Name = "btnCustomerPage";
            btnCustomerPage.Size = new Size(131, 29);
            btnCustomerPage.TabIndex = 4;
            btnCustomerPage.Text = "Сторінка \"Покупці\"";
            btnCustomerPage.UseVisualStyleBackColor = true;
            // 
            // btnRequestPage
            // 
            btnRequestPage.Location = new Point(434, 449);
            btnRequestPage.Name = "btnRequestPage";
            btnRequestPage.Size = new Size(131, 29);
            btnRequestPage.TabIndex = 6;
            btnRequestPage.Text = "Сторінка \"Заявки\"";
            btnRequestPage.UseVisualStyleBackColor = true;
            btnRequestPage.Click += btnRequestPage_Click;
            // 
            // cmbSearch
            // 
            cmbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Items.AddRange(new object[] { "Id", "Ім'я", "Бюджет <=" });
            cmbSearch.Location = new Point(12, 27);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(155, 23);
            cmbSearch.TabIndex = 11;
            // 
            // btnSearchReset
            // 
            btnSearchReset.Location = new Point(201, 27);
            btnSearchReset.Name = "btnSearchReset";
            btnSearchReset.Size = new Size(131, 52);
            btnSearchReset.TabIndex = 14;
            btnSearchReset.Text = "Прибрати фільтр";
            btnSearchReset.UseVisualStyleBackColor = true;
            btnSearchReset.Click += btnSearchReset_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 56);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(118, 23);
            txtSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, manageToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(597, 24);
            menuStrip1.TabIndex = 17;
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
            // CustomersPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 490);
            Controls.Add(menuStrip1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSearchReset);
            Controls.Add(cmbSearch);
            Controls.Add(btnRequestPage);
            Controls.Add(btnCustomerPage);
            Controls.Add(btnMainPage);
            Controls.Add(btnEditCustomer);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnAddNew);
            Controls.Add(dgvCustomers);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CustomersPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Менеджмент покупців";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnMainPage;
        private Button btnCustomerPage;
        private Button btnRequestPage;
        private DataGridViewTextBoxColumn dgvTxtId;
        private DataGridViewTextBoxColumn dgvTxtColumnName;
        private DataGridViewTextBoxColumn dgvTxtColumnNumber;
        private DataGridViewTextBoxColumn dgvTxtColumnPrefferedBrand;
        private DataGridViewTextBoxColumn dgvTxtColumnPrefferedCondition;
        private DataGridViewTextBoxColumn dgvTxtColumnPrefferedYear;
        private DataGridViewTextBoxColumn dgvTxtColumnBudget;
        private ComboBox cmbSearch;
        private Button btnSearchReset;
        private TextBox txtSearch;
        private Button btnSearch;
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
