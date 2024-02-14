namespace Chat.Forms.Auth
{
    partial class AuthForm
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
            lblBirthdate = new Label();
            lblSurname = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            dtBirthdate = new DateTimePicker();
            lblUserName = new Label();
            tbLogin = new TextBox();
            tbEmail = new TextBox();
            tbName = new TextBox();
            tbSurname = new TextBox();
            btnOk = new Button();
            btnToLogin = new Button();
            tbConfirmPassword = new TextBox();
            tbPassword = new TextBox();
            panelRegister = new Panel();
            panelLogin = new Panel();
            btnToRegister = new Button();
            btnLogin = new Button();
            tbLoginPassword = new TextBox();
            label2 = new Label();
            tbLoginEmail = new TextBox();
            label1 = new Label();
            panelRegister.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirthdate.Location = new Point(3, 237);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(151, 23);
            lblBirthdate.TabIndex = 17;
            lblBirthdate.Text = "Дата народження";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSurname.Location = new Point(3, 352);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(86, 23);
            lblSurname.TabIndex = 16;
            lblSurname.Text = "Прізвище";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(3, 293);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 23);
            lblName.TabIndex = 15;
            lblName.Text = "Ім'я";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(3, 60);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 23);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Пошта";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(3, 119);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 23);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Пароль";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmPassword.Location = new Point(3, 178);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(197, 23);
            lblConfirmPassword.TabIndex = 12;
            lblConfirmPassword.Text = "Підтвердження паролю";
            // 
            // dtBirthdate
            // 
            dtBirthdate.Location = new Point(3, 263);
            dtBirthdate.Name = "dtBirthdate";
            dtBirthdate.Size = new Size(200, 27);
            dtBirthdate.TabIndex = 11;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(3, 1);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(52, 23);
            lblUserName.TabIndex = 10;
            lblUserName.Text = "Логін";
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbLogin.Location = new Point(3, 27);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(200, 30);
            tbLogin.TabIndex = 9;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Location = new Point(3, 86);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(200, 30);
            tbEmail.TabIndex = 18;
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(3, 319);
            tbName.Name = "tbName";
            tbName.Size = new Size(200, 30);
            tbName.TabIndex = 21;
            // 
            // tbSurname
            // 
            tbSurname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbSurname.Location = new Point(3, 378);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(200, 30);
            tbSurname.TabIndex = 22;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(3, 429);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 23;
            btnOk.Text = "Ок";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnToLogin
            // 
            btnToLogin.Location = new Point(106, 429);
            btnToLogin.Name = "btnToLogin";
            btnToLogin.Size = new Size(94, 29);
            btnToLogin.TabIndex = 24;
            btnToLogin.Text = "Увійти";
            btnToLogin.UseVisualStyleBackColor = true;
            btnToLogin.Click += btnToLogin_Click;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbConfirmPassword.Location = new Point(3, 204);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '*';
            tbConfirmPassword.Size = new Size(200, 30);
            tbConfirmPassword.TabIndex = 20;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(3, 145);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(200, 30);
            tbPassword.TabIndex = 19;
            // 
            // panelRegister
            // 
            panelRegister.Controls.Add(tbLogin);
            panelRegister.Controls.Add(btnToLogin);
            panelRegister.Controls.Add(lblUserName);
            panelRegister.Controls.Add(btnOk);
            panelRegister.Controls.Add(dtBirthdate);
            panelRegister.Controls.Add(tbSurname);
            panelRegister.Controls.Add(lblConfirmPassword);
            panelRegister.Controls.Add(tbName);
            panelRegister.Controls.Add(lblPassword);
            panelRegister.Controls.Add(tbConfirmPassword);
            panelRegister.Controls.Add(lblEmail);
            panelRegister.Controls.Add(tbPassword);
            panelRegister.Controls.Add(lblName);
            panelRegister.Controls.Add(tbEmail);
            panelRegister.Controls.Add(lblSurname);
            panelRegister.Controls.Add(lblBirthdate);
            panelRegister.Location = new Point(82, 12);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(208, 484);
            panelRegister.TabIndex = 25;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(btnToRegister);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(tbLoginPassword);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(tbLoginEmail);
            panelLogin.Controls.Add(label1);
            panelLogin.Location = new Point(63, 131);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(250, 207);
            panelLogin.TabIndex = 26;
            // 
            // btnToRegister
            // 
            btnToRegister.Location = new Point(109, 130);
            btnToRegister.Name = "btnToRegister";
            btnToRegister.Size = new Size(138, 29);
            btnToRegister.TabIndex = 25;
            btnToRegister.Text = "Зареєструватися";
            btnToRegister.UseVisualStyleBackColor = true;
            btnToRegister.Click += btnToRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(3, 130);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 25;
            btnLogin.Text = "Увійти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbLoginPassword
            // 
            tbLoginPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbLoginPassword.Location = new Point(3, 85);
            tbLoginPassword.Name = "tbLoginPassword";
            tbLoginPassword.PasswordChar = '*';
            tbLoginPassword.Size = new Size(244, 30);
            tbLoginPassword.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 59);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 25;
            label2.Text = "Пароль";
            // 
            // tbLoginEmail
            // 
            tbLoginEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbLoginEmail.Location = new Point(3, 26);
            tbLoginEmail.Name = "tbLoginEmail";
            tbLoginEmail.Size = new Size(244, 30);
            tbLoginEmail.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 25;
            label1.Text = "Пошта або логін";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 508);
            Controls.Add(panelLogin);
            Controls.Add(panelRegister);
            MinimizeBox = false;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реєстрація";
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblBirthdate;
        private Label lblSurname;
        private Label lblName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private DateTimePicker dtBirthdate;
        private Label lblUserName;
        private TextBox tbLogin;
        private TextBox tbEmail;
        private TextBox tbName;
        private TextBox tbSurname;
        private Button btnOk;
        private Button btnToLogin;
        private TextBox tbConfirmPassword;
        private TextBox tbPassword;
        private Panel panelRegister;
        private Panel panelLogin;
        private Button btnToRegister;
        private Button btnLogin;
        private TextBox tbLoginPassword;
        private Label label2;
        private TextBox tbLoginEmail;
        private Label label1;
    }
}