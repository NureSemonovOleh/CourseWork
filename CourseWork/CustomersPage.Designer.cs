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
            dgvCustomers = new DataGridView();
            dgvTxtColumnName = new DataGridViewTextBoxColumn();
            dgvTxtColumnNumber = new DataGridViewTextBoxColumn();
            dgvTxtColumnPrefferedBrand = new DataGridViewTextBoxColumn();
            dgvTxtColumnPrefferedCondition = new DataGridViewTextBoxColumn();
            dgvTxtColumnPrefferedYear = new DataGridViewTextBoxColumn();
            dgvTxtColumnMinMaxSpeed = new DataGridViewTextBoxColumn();
            dgvTxtColumnBudget = new DataGridViewTextBoxColumn();
            btnAddNew = new Button();
            btnDeleteCustomer = new Button();
            btnDeleteAll = new Button();
            btnEditCustomer = new Button();
            btnMainPage = new Button();
            btnCustomerPage = new Button();
            btnRequestPage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { dgvTxtColumnName, dgvTxtColumnNumber, dgvTxtColumnPrefferedBrand, dgvTxtColumnPrefferedCondition, dgvTxtColumnPrefferedYear, dgvTxtColumnMinMaxSpeed, dgvTxtColumnBudget });
            dgvCustomers.Location = new Point(4, 150);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ScrollBars = ScrollBars.Vertical;
            dgvCustomers.Size = new Size(573, 167);
            dgvCustomers.TabIndex = 0;
            // 
            // dgvTxtColumnName
            // 
            dgvTxtColumnName.HeaderText = "Ім'я";
            dgvTxtColumnName.Name = "dgvTxtColumnName";
            dgvTxtColumnName.ReadOnly = true;
            dgvTxtColumnName.Width = 75;
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
            dgvTxtColumnPrefferedCondition.Width = 75;
            // 
            // dgvTxtColumnPrefferedYear
            // 
            dgvTxtColumnPrefferedYear.HeaderText = "Бажано від ... року";
            dgvTxtColumnPrefferedYear.MaxInputLength = 4;
            dgvTxtColumnPrefferedYear.Name = "dgvTxtColumnPrefferedYear";
            dgvTxtColumnPrefferedYear.ReadOnly = true;
            dgvTxtColumnPrefferedYear.Width = 53;
            // 
            // dgvTxtColumnMinMaxSpeed
            // 
            dgvTxtColumnMinMaxSpeed.HeaderText = "Бажано від макс. швидкості";
            dgvTxtColumnMinMaxSpeed.MaxInputLength = 3;
            dgvTxtColumnMinMaxSpeed.Name = "dgvTxtColumnMinMaxSpeed";
            dgvTxtColumnMinMaxSpeed.ReadOnly = true;
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
            btnAddNew.Location = new Point(4, 323);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(131, 55);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Додати покупця";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(232, 323);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(131, 55);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "Видалити покупця";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(446, 323);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(131, 55);
            btnDeleteAll.TabIndex = 3;
            btnDeleteAll.Text = "Видалити всіх";
            btnDeleteAll.UseVisualStyleBackColor = true;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new Point(232, 384);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(131, 55);
            btnEditCustomer.TabIndex = 4;
            btnEditCustomer.Text = "Редагувати покупця";
            btnEditCustomer.UseVisualStyleBackColor = true;
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
            btnRequestPage.Location = new Point(448, 449);
            btnRequestPage.Name = "btnRequestPage";
            btnRequestPage.Size = new Size(131, 29);
            btnRequestPage.TabIndex = 6;
            btnRequestPage.Text = "Сторінка \"Заявки\"";
            btnRequestPage.UseVisualStyleBackColor = true;
            btnRequestPage.Click += btnRequestPage_Click;
            // 
            // CustomersPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 490);
            Controls.Add(btnRequestPage);
            Controls.Add(btnCustomerPage);
            Controls.Add(btnMainPage);
            Controls.Add(btnEditCustomer);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnAddNew);
            Controls.Add(dgvCustomers);
            Name = "CustomersPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Менеджмент покупців";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
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
        private DataGridViewTextBoxColumn dgvTxtColumnName;
        private DataGridViewTextBoxColumn dgvTxtColumnNumber;
        private DataGridViewTextBoxColumn dgvTxtColumnPrefferedBrand;
        private DataGridViewTextBoxColumn dgvTxtColumnPrefferedCondition;
        private DataGridViewTextBoxColumn dgvTxtColumnPrefferedYear;
        private DataGridViewTextBoxColumn dgvTxtColumnMinMaxSpeed;
        private DataGridViewTextBoxColumn dgvTxtColumnBudget;
    }




}
