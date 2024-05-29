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
            lstCars = new ListBox();
            btnAddNew = new Button();
            SuspendLayout();
            // 
            // lstCars
            // 
            lstCars.FormattingEnabled = true;
            lstCars.ItemHeight = 15;
            lstCars.Location = new Point(12, 51);
            lstCars.Name = "lstCars";
            lstCars.Size = new Size(426, 169);
            lstCars.TabIndex = 0;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(12, 253);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(211, 76);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "button1";
            btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new EventHandler(this.btnAddNew_Click);
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddNew);
            Controls.Add(lstCars);
            Name = "MainWindow";
            Text = "Form1";
            Load += MainWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstCars;
        private Button btnAddNew;
    }
}
