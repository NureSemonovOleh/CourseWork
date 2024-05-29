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
            SuspendLayout();
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(12, 12);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(121, 23);
            cmbBrand.TabIndex = 0;
            // 
            // cmbModels
            // 
            cmbModels.FormattingEnabled = true;
            cmbModels.Location = new Point(12, 41);
            cmbModels.Name = "cmbModels";
            cmbModels.Size = new Size(121, 23);
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
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 474);
            Controls.Add(cmbCondition);
            Controls.Add(cmbModels);
            Controls.Add(cmbBrand);
            Name = "AddCarForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbBrand;
        private ComboBox cmbModels;
        private ComboBox cmbCondition;
    }
}