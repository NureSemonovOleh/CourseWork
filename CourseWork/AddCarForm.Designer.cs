namespace CourseWork
{
    partial class AddCarForm
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
            cmbBrand = new ComboBox();
            cmbModels = new ComboBox();
            cmbCondition = new ComboBox();
            txtYear = new TextBox();
            txtMaxSpeed = new TextBox();
            txtEngineVolume = new TextBox();
            txtPrice = new TextBox();
            btnAddCar = new Button();
            SuspendLayout();
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(12, 12);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(121, 23);
            cmbBrand.Sorted = true;
            cmbBrand.TabIndex = 0;
            // 
            // cmbModels
            // 
            cmbModels.FormattingEnabled = true;
            cmbModels.Location = new Point(12, 41);
            cmbModels.Name = "cmbModels";
            cmbModels.Size = new Size(121, 23);
            cmbModels.Sorted = true;
            cmbModels.TabIndex = 1;
            cmbModels.SelectedIndexChanged += cmbModels_SelectedIndexChanged;
            // 
            // cmbCondition
            // 
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(12, 70);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(121, 23);
            cmbCondition.TabIndex = 2;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(12, 99);
            txtYear.MaxLength = 4;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 3;
            // 
            // txtMaxSpeed
            // 
            txtMaxSpeed.Location = new Point(12, 128);
            txtMaxSpeed.MaxLength = 3;
            txtMaxSpeed.Name = "txtMaxSpeed";
            txtMaxSpeed.Size = new Size(100, 23);
            txtMaxSpeed.TabIndex = 4;
            // 
            // txtEngineVolume
            // 
            txtEngineVolume.Location = new Point(12, 157);
            txtEngineVolume.Name = "txtEngineVolume";
            txtEngineVolume.Size = new Size(100, 23);
            txtEngineVolume.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 186);
            txtPrice.MaxLength = 7;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 6;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(124, 335);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(75, 23);
            btnAddCar.TabIndex = 7;
            btnAddCar.Text = "Add car";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += new System.EventHandler(btnAddCar_Click);
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 474);
            Controls.Add(btnAddCar);
            Controls.Add(txtPrice);
            Controls.Add(txtEngineVolume);
            Controls.Add(txtMaxSpeed);
            Controls.Add(txtYear);
            Controls.Add(cmbCondition);
            Controls.Add(cmbModels);
            Controls.Add(cmbBrand);
            Name = "AddCarForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBrand;
        private ComboBox cmbModels;
        private ComboBox cmbCondition;
        private TextBox txtYear;
        private TextBox txtMaxSpeed;
        private TextBox txtEngineVolume;
        private TextBox txtPrice;
        private Button btnAddCar;
    }
}