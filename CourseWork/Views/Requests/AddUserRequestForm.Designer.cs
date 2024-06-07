namespace CourseWork
{
    partial class AddUserRequestForm
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
            txtName = new TextBox();
            txtNumber = new TextBox();
            cmbCars = new ComboBox();
            btnAddRequest = new Button();
            lblName = new Label();
            lblNumber = new Label();
            lblCars = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 29);
            txtName.MaxLength = 30;
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 23);
            txtName.TabIndex = 0;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(12, 68);
            txtNumber.MaxLength = 10;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(260, 23);
            txtNumber.TabIndex = 1;
            txtNumber.KeyPress += txtNumber_KeyPress;
            // 
            // cmbCars
            // 
            cmbCars.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCars.FormattingEnabled = true;
            cmbCars.Location = new Point(12, 107);
            cmbCars.Name = "cmbCars";
            cmbCars.Size = new Size(260, 23);
            cmbCars.TabIndex = 2;
            // 
            // btnAddRequest
            // 
            btnAddRequest.Location = new Point(12, 144);
            btnAddRequest.Name = "btnAddRequest";
            btnAddRequest.Size = new Size(260, 23);
            btnAddRequest.TabIndex = 3;
            btnAddRequest.Text = "Додати заявку";
            btnAddRequest.UseVisualStyleBackColor = true;
            btnAddRequest.Click += btnAddRequest_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 13);
            lblName.Name = "lblName";
            lblName.Size = new Size(31, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Ім'я:";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(12, 52);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(48, 15);
            lblNumber.TabIndex = 5;
            lblNumber.Text = "Номер:";
            // 
            // lblCars
            // 
            lblCars.AutoSize = true;
            lblCars.Location = new Point(12, 91);
            lblCars.Name = "lblCars";
            lblCars.Size = new Size(68, 15);
            lblCars.TabIndex = 6;
            lblCars.Text = "Вибір авто:";
            // 
            // AddUserRequestForm
            // 
            ClientSize = new Size(284, 181);
            Controls.Add(lblCars);
            Controls.Add(lblNumber);
            Controls.Add(lblName);
            Controls.Add(btnAddRequest);
            Controls.Add(cmbCars);
            Controls.Add(txtNumber);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddUserRequestForm";
            Text = "Додати заявку";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ComboBox cmbCars;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCars;

        #endregion
    }
}