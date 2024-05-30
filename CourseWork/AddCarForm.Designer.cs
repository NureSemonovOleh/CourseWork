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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarForm));
            cmbBrand = new ComboBox();
            cmbModels = new ComboBox();
            cmbCondition = new ComboBox();
            txtYear = new TextBox();
            txtMaxSpeed = new TextBox();
            txtEngineVolume = new TextBox();
            txtPrice = new TextBox();
            btnAddCar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // cmbBrand
            // 
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(12, 27);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(121, 23);
            cmbBrand.Sorted = true;
            cmbBrand.TabIndex = 0;
            // 
            // cmbModels
            // 
            cmbModels.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModels.FormattingEnabled = true;
            cmbModels.Location = new Point(12, 71);
            cmbModels.Name = "cmbModels";
            cmbModels.Size = new Size(121, 23);
            cmbModels.Sorted = true;
            cmbModels.TabIndex = 1;
            cmbModels.SelectedIndexChanged += cmbModels_SelectedIndexChanged;
            // 
            // cmbCondition
            // 
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(12, 115);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(121, 23);
            cmbCondition.TabIndex = 2;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(12, 159);
            txtYear.MaxLength = 4;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(121, 23);
            txtYear.TabIndex = 3;
            // 
            // txtMaxSpeed
            // 
            txtMaxSpeed.Location = new Point(12, 201);
            txtMaxSpeed.MaxLength = 3;
            txtMaxSpeed.Name = "txtMaxSpeed";
            txtMaxSpeed.Size = new Size(121, 23);
            txtMaxSpeed.TabIndex = 4;
            txtMaxSpeed.KeyPress += txtMaxSpeed_KeyPress;
            // 
            // txtEngineVolume
            // 
            txtEngineVolume.Location = new Point(12, 245);
            txtEngineVolume.MaxLength = 3;
            txtEngineVolume.Name = "txtEngineVolume";
            txtEngineVolume.Size = new Size(121, 23);
            txtEngineVolume.TabIndex = 5;
            txtEngineVolume.KeyPress += txtEngineVolume_KeyPress;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 289);
            txtPrice.MaxLength = 7;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 6;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(96, 337);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(159, 106);
            btnAddCar.TabIndex = 7;
            btnAddCar.Text = "Додати авто";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 8;
            label1.Text = "Марка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 9;
            label2.Text = "Модель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 10;
            label3.Text = "Стан авто";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 11;
            label4.Text = "Рік випуску";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(143, 15);
            label5.TabIndex = 12;
            label5.Text = "Максимальна швидкість";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 227);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 13;
            label6.Text = "Об'єм двигуна";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 271);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 14;
            label7.Text = "Ціна";
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 455);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddCar);
            Controls.Add(txtPrice);
            Controls.Add(txtEngineVolume);
            Controls.Add(txtMaxSpeed);
            Controls.Add(txtYear);
            Controls.Add(cmbCondition);
            Controls.Add(cmbModels);
            Controls.Add(cmbBrand);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddCarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додати авто";
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}