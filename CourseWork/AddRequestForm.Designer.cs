namespace CourseWork
{
    partial class AddRequestForm
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
            cmbCustomer = new ComboBox();
            cmbCars = new ComboBox();
            btnAddRequest = new Button();
            SuspendLayout();
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(12, 43);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(121, 23);
            cmbCustomer.TabIndex = 0;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // cmbCars
            // 
            cmbCars.FormattingEnabled = true;
            cmbCars.Location = new Point(12, 95);
            cmbCars.Name = "cmbCars";
            cmbCars.Size = new Size(121, 23);
            cmbCars.TabIndex = 1;
            // 
            // btnAddRequest
            // 
            btnAddRequest.Location = new Point(194, 253);
            btnAddRequest.Name = "btnAddRequest";
            btnAddRequest.Size = new Size(75, 23);
            btnAddRequest.TabIndex = 2;
            btnAddRequest.Text = "Додати заявку";
            btnAddRequest.UseVisualStyleBackColor = true;
            btnAddRequest.Click += btnAddRequest_Click;

            // 
            // AddRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddRequest);
            Controls.Add(cmbCars);
            Controls.Add(cmbCustomer);
            Name = "AddRequestForm";
            Text = "Form1";
            ResumeLayout(false);
            
        }

        #endregion

        private ComboBox cmbCustomer;
        private ComboBox cmbCars;
        private Button btnAddRequest;
    }
}