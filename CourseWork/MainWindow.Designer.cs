namespace CourseWork
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            btnAddNew = new Button();
            dgvCars = new DataGridView();
            dgvTxtColumnId = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
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
            btnCustomerPage = new Button();
            btnMainPage = new Button();
            btnRequestPage = new Button();
            btnDeleteCar = new Button();
            btnDeleteAll = new Button();
            btnEdit = new Button();
            cmbSearch = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnSearchReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(12, 325);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(131, 55);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Додати авто";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.AllowUserToResizeColumns = false;
            dgvCars.AllowUserToResizeRows = false;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Columns.AddRange(new DataGridViewColumn[] { dgvTxtColumnId, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvCars.Location = new Point(12, 130);
            dgvCars.Name = "dgvCars";
            dgvCars.ScrollBars = ScrollBars.Vertical;
            dgvCars.Size = new Size(553, 189);
            dgvCars.TabIndex = 2;
            // 
            // dgvTxtColumnId
            // 
            dgvTxtColumnId.HeaderText = "ID";
            dgvTxtColumnId.MaxInputLength = 3;
            dgvTxtColumnId.Name = "dgvTxtColumnId";
            dgvTxtColumnId.ReadOnly = true;
            dgvTxtColumnId.Resizable = DataGridViewTriState.False;
            dgvTxtColumnId.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Марка";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Модель";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Стан";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Рік";
            dataGridViewTextBoxColumn5.MaxInputLength = 4;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Макс.швидкість";
            dataGridViewTextBoxColumn6.MaxInputLength = 3;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Об'єм двигуну";
            dataGridViewTextBoxColumn7.MaxInputLength = 3;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Ціна";
            dataGridViewTextBoxColumn8.MaxInputLength = 7;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn8.Width = 80;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, manageToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(597, 24);
            menuStrip1.TabIndex = 3;
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
            // btnCustomerPage
            // 
            btnCustomerPage.Location = new Point(232, 449);
            btnCustomerPage.Name = "btnCustomerPage";
            btnCustomerPage.Size = new Size(131, 29);
            btnCustomerPage.TabIndex = 4;
            btnCustomerPage.Text = "Сторінка \"Покупці\"";
            btnCustomerPage.UseVisualStyleBackColor = true;
            btnCustomerPage.Click += btnCustomerPage_Click;
            // 
            // btnMainPage
            // 
            btnMainPage.Location = new Point(12, 449);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(131, 29);
            btnMainPage.TabIndex = 5;
            btnMainPage.Text = "Сторінка \"Авто\"";
            btnMainPage.UseVisualStyleBackColor = true;
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
            // btnDeleteCar
            // 
            btnDeleteCar.Location = new Point(232, 325);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(131, 55);
            btnDeleteCar.TabIndex = 7;
            btnDeleteCar.Text = "Видалити авто";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDelete_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(434, 325);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(131, 55);
            btnDeleteAll.TabIndex = 8;
            btnDeleteAll.Text = "Видалити все";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(232, 386);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 57);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Редагувати авто";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEditCar_Click;
            // 
            // cmbSearch
            // 
            cmbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Items.AddRange(new object[] { "ID", "Brand", "Price <= ", "Condition" });
            cmbSearch.Location = new Point(12, 27);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(155, 23);
            cmbSearch.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 56);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(118, 23);
            txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSearchReset
            // 
            btnSearchReset.Location = new Point(212, 27);
            btnSearchReset.Name = "btnSearchReset";
            btnSearchReset.Size = new Size(131, 52);
            btnSearchReset.TabIndex = 13;
            btnSearchReset.Text = "Прибрати фільтр";
            btnSearchReset.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 490);
            Controls.Add(btnSearchReset);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cmbSearch);
            Controls.Add(btnEdit);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDeleteCar);
            Controls.Add(btnRequestPage);
            Controls.Add(btnMainPage);
            Controls.Add(btnCustomerPage);
            Controls.Add(dgvCars);
            Controls.Add(btnAddNew);
            Controls.Add(menuStrip1);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Менеджмент автосалону";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddNew;
        private DataGridView dgvCars;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnCustomerPage;
        private Button btnMainPage;
        private Button btnRequestPage;
        private Button btnDeleteCar;
        private Button btnDeleteAll;
        private Button btnEdit;
        private ComboBox cmbSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnSearchReset;
        private DataGridViewTextBoxColumn dgvTxtColumnId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
