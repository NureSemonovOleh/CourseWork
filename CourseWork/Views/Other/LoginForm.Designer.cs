namespace CourseWork
{
    partial class LoginForm
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
            btnUserMode = new Button();
            btnAdminMode = new Button();
            SuspendLayout();
            // 
            // btnUserMode
            // 
            btnUserMode.Location = new Point(14, 14);
            btnUserMode.Margin = new Padding(4, 3, 4, 3);
            btnUserMode.Name = "btnUserMode";
            btnUserMode.Size = new Size(303, 27);
            btnUserMode.TabIndex = 0;
            btnUserMode.Text = "Клієнт";
            btnUserMode.UseVisualStyleBackColor = true;
            btnUserMode.Click += btnUserMode_Click;
            // 
            // btnAdminMode
            // 
            btnAdminMode.Location = new Point(14, 47);
            btnAdminMode.Margin = new Padding(4, 3, 4, 3);
            btnAdminMode.Name = "btnAdminMode";
            btnAdminMode.Size = new Size(303, 27);
            btnAdminMode.TabIndex = 1;
            btnAdminMode.Text = "Адміністратор";
            btnAdminMode.UseVisualStyleBackColor = true;
            btnAdminMode.Click += btnAdminMode_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 88);
            Controls.Add(btnAdminMode);
            Controls.Add(btnUserMode);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вхід";
            ResumeLayout(false);
        }

        private Button btnUserMode;
        private Button btnAdminMode;
        #endregion
    }
}