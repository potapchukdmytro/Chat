namespace Chat.Forms.Profile
{
    partial class ChangeProfile
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
            tbLogin = new TextBox();
            lbLogin = new Label();
            lbEmail = new Label();
            lbName = new Label();
            lbSurname = new Label();
            tbEmail = new TextBox();
            tbName = new TextBox();
            tbSurname = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(180, 36);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(125, 27);
            tbLogin.TabIndex = 0;
            // 
            // lbLogin
            // 
            lbLogin.Location = new Point(112, 39);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(62, 25);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "Логін";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(112, 79);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(55, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Пошта";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(112, 119);
            lbName.Name = "lbName";
            lbName.Size = new Size(35, 20);
            lbName.TabIndex = 3;
            lbName.Text = "Ім'я";
            // 
            // lbSurname
            // 
            lbSurname.AutoSize = true;
            lbSurname.Location = new Point(90, 160);
            lbSurname.Name = "lbSurname";
            lbSurname.Size = new Size(77, 20);
            lbSurname.TabIndex = 4;
            lbSurname.Text = "Прізвище";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(180, 76);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 5;
            // 
            // tbName
            // 
            tbName.Location = new Point(180, 116);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 6;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(180, 157);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(125, 27);
            tbSurname.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(189, 212);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ChangeProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 276);
            Controls.Add(btnSave);
            Controls.Add(tbSurname);
            Controls.Add(tbName);
            Controls.Add(tbEmail);
            Controls.Add(lbSurname);
            Controls.Add(lbName);
            Controls.Add(lbEmail);
            Controls.Add(lbLogin);
            Controls.Add(tbLogin);
            Name = "ChangeProfile";
            Text = "ChangeProfile";
            Load += ChangeProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLogin;
        private Label lbLogin;
        private Label lbEmail;
        private Label lbName;
        private Label lbSurname;
        private TextBox tbEmail;
        private TextBox tbName;
        private TextBox tbSurname;
        private Button btnSave;
    }
}