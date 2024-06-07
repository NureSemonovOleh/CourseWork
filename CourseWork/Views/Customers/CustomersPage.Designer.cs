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
            SaveFileAsToolStripMenuItem = new ToolStripMenuItem();
            loadFileToolStripMenuItem = new ToolStripMenuItem();
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
            dgvCustomers.TabStop = false;
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
            btnAddNew.TabIndex = 5;
            btnAddNew.Text = "Додати покупця";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(232, 327);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(131, 55);
            btnDeleteCustomer.TabIndex = 6;
            btnDeleteCustomer.Text = "Видалити покупця";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(434, 327);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(131, 55);
            btnDeleteAll.TabIndex = 7;
            btnDeleteAll.Text = "Видалити всіх";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new Point(232, 388);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(131, 55);
            btnEditCustomer.TabIndex = 8;
            btnEditCustomer.Text = "Редагувати покупця";
            btnEditCustomer.UseVisualStyleBackColor = true;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // btnMainPage
            // 
            btnMainPage.Location = new Point(12, 449);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(131, 29);
            btnMainPage.TabIndex = 9;
            btnMainPage.Text = "Сторінка \"Авто\"";
            btnMainPage.UseVisualStyleBackColor = true;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // btnCustomerPage
            // 
            btnCustomerPage.Location = new Point(232, 449);
            btnCustomerPage.Name = "btnCustomerPage";
            btnCustomerPage.Size = new Size(131, 29);
            btnCustomerPage.TabIndex = 10;
            btnCustomerPage.Text = "Сторінка \"Покупці\"";
            btnCustomerPage.UseVisualStyleBackColor = true;
            // 
            // btnRequestPage
            // 
            btnRequestPage.Location = new Point(434, 449);
            btnRequestPage.Name = "btnRequestPage";
            btnRequestPage.Size = new Size(131, 29);
            btnRequestPage.TabIndex = 11;
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
            cmbSearch.TabIndex = 1;
            // 
            // btnSearchReset
            // 
            btnSearchReset.Location = new Point(201, 27);
            btnSearchReset.Name = "btnSearchReset";
            btnSearchReset.Size = new Size(131, 52);
            btnSearchReset.TabIndex = 4;
            btnSearchReset.Text = "Прибрати фільтр";
            btnSearchReset.UseVisualStyleBackColor = true;
            btnSearchReset.Click += btnSearchReset_Click;
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
            saveFileMenuItem.ShortcutKeyDisplayString = "Ctrl + s";
            saveFileMenuItem.Size = new Size(254, 22);
            saveFileMenuItem.Text = "Зберегти файл";
            saveFileMenuItem.Click += saveFileMenuItem_Click;
            // 
            // SaveFileAsToolStripMenuItem
            // 
            SaveFileAsToolStripMenuItem.Name = "SaveFileAsToolStripMenuItem";
            SaveFileAsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Shift + s";
            SaveFileAsToolStripMenuItem.Size = new Size(254, 22);
            SaveFileAsToolStripMenuItem.Text = "Зберегти файл як";
            SaveFileAsToolStripMenuItem.Click += SaveFileAsToolStripMenuItem_Click;
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            loadFileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + L";
            loadFileToolStripMenuItem.Size = new Size(254, 22);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "CustomersPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Менеджмент покупців";
            Load += CustomersPage_Load;
            KeyDown += CustomersPage_KeyDown;
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
        private ToolStripMenuItem SaveFileAsToolStripMenuItem;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpButtonsToolStripMenuItem;
    }




}
