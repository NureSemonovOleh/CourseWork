namespace CourseWork
{
    partial class AddCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
            txtName = new TextBox();
            txtNumber = new TextBox();
            cmbPrefferedBrand = new ComboBox();
            txtPrefferedYear = new TextBox();
            cmbPrefferedCondition = new ComboBox();
            txtBudget = new TextBox();
            btnAddCustomer = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(120, 23);
            txtName.TabIndex = 0;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(12, 84);
            txtNumber.MaxLength = 10;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(120, 23);
            txtNumber.TabIndex = 1;
            // 
            // cmbPrefferedBrand
            // 
            cmbPrefferedBrand.FormattingEnabled = true;
            cmbPrefferedBrand.Items.AddRange(new object[] { "Toyota", "Nissan", "Ford" });
            cmbPrefferedBrand.Location = new Point(12, 132);
            cmbPrefferedBrand.Name = "cmbPrefferedBrand";
            cmbPrefferedBrand.Size = new Size(120, 23);
            cmbPrefferedBrand.TabIndex = 2;
            // 
            // txtPrefferedYear
            // 
            txtPrefferedYear.Location = new Point(12, 176);
            txtPrefferedYear.MaxLength = 4;
            txtPrefferedYear.Name = "txtPrefferedYear";
            txtPrefferedYear.Size = new Size(120, 23);
            txtPrefferedYear.TabIndex = 3;
            // 
            // cmbPrefferedCondition
            // 
            cmbPrefferedCondition.FormattingEnabled = true;
            cmbPrefferedCondition.Items.AddRange(new object[] { "New", "Used", "Old" });
            cmbPrefferedCondition.Location = new Point(12, 220);
            cmbPrefferedCondition.Name = "cmbPrefferedCondition";
            cmbPrefferedCondition.Size = new Size(120, 23);
            cmbPrefferedCondition.TabIndex = 5;
            // 
            // txtBudget
            // 
            txtBudget.Location = new Point(12, 265);
            txtBudget.MaxLength = 9;
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(120, 23);
            txtBudget.TabIndex = 6;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(43, 323);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(260, 61);
            btnAddCustomer.TabIndex = 7;
            btnAddCustomer.Text = "Додати покупця";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 8;
            label1.Text = "Ім'я клієнта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 9;
            label2.Text = "Номер клієнта (без +38)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 10;
            label3.Text = "Бажана марка";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 11;
            label4.Text = "Бажаний рік";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 202);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 12;
            label5.Text = "Бажаний стан авто";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 246);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 13;
            label6.Text = "Бюджет клієнта";
            // 
            // AddCustomerForm
            // 
            ClientSize = new Size(354, 424);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddCustomer);
            Controls.Add(txtBudget);
            Controls.Add(cmbPrefferedCondition);
            Controls.Add(txtPrefferedYear);
            Controls.Add(cmbPrefferedBrand);
            Controls.Add(txtNumber);
            Controls.Add(txtName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddCustomerForm";
            Text = "Додати покупця";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtNumber;
        private ComboBox cmbPrefferedBrand;
        private TextBox txtPrefferedYear;
        private ComboBox cmbPrefferedCondition;
        private TextBox txtBudget;
        private Button btnAddCustomer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}