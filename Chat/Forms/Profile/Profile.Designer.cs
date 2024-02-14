namespace Chat.Forms.Profile
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            pictureBox1 = new PictureBox();
            lbUsername = new Label();
            lbEmail = new Label();
            lbName = new Label();
            btnSave = new Button();
            btnSettings = new Button();
            lbSurname = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(39, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.ForeColor = Color.Chocolate;
            lbUsername.Location = new Point(216, 42);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(91, 41);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Логін";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.ForeColor = Color.Chocolate;
            lbEmail.Location = new Point(216, 93);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(108, 41);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Пошта";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.ForeColor = Color.Chocolate;
            lbName.Location = new Point(216, 134);
            lbName.Name = "lbName";
            lbName.Size = new Size(69, 41);
            lbName.TabIndex = 3;
            lbName.Text = "Ім'я";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(55, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(191, 282);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(94, 29);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Змінити";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // lbSurname
            // 
            lbSurname.AutoSize = true;
            lbSurname.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbSurname.ForeColor = Color.Chocolate;
            lbSurname.Location = new Point(216, 175);
            lbSurname.Name = "lbSurname";
            lbSurname.Size = new Size(151, 41);
            lbSurname.TabIndex = 7;
            lbSurname.Text = "Прізвище";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 354);
            Controls.Add(lbSurname);
            Controls.Add(btnSettings);
            Controls.Add(btnSave);
            Controls.Add(lbName);
            Controls.Add(lbEmail);
            Controls.Add(lbUsername);
            Controls.Add(pictureBox1);
            Name = "ProfileForm";
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbUsername;
        private Label lbEmail;
        private Label lbName;
        private Button btnSave;
        private Button btnSettings;
        private Label lbSurname;
    }
}