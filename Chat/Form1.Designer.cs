namespace Chat
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnProfile = new Button();
            chatList = new ListBox();
            label1 = new Label();
            tbMessage = new TextBox();
            messagesBox = new RichTextBox();
            btnCreateChat = new Button();
            userList = new ListBox();
            label2 = new Label();
            btnJoin = new Button();
            btnLogout = new Button();
            btnSendMeesage = new Button();
            cmMessage = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cmMessage.SuspendLayout();
            SuspendLayout();
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(519, 18);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(94, 29);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Профіль";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // chatList
            // 
            chatList.BackColor = SystemColors.ActiveBorder;
            chatList.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            chatList.ForeColor = SystemColors.InactiveCaptionText;
            chatList.FormattingEnabled = true;
            chatList.ItemHeight = 20;
            chatList.Location = new Point(12, 53);
            chatList.Name = "chatList";
            chatList.Size = new Size(208, 344);
            chatList.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 2;
            label1.Text = "Список чатів";
            // 
            // tbMessage
            // 
            tbMessage.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbMessage.Location = new Point(226, 433);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(438, 43);
            tbMessage.TabIndex = 3;
            tbMessage.KeyDown += tbMessage_KeyDown;
            // 
            // messagesBox
            // 
            messagesBox.Location = new Point(226, 53);
            messagesBox.Name = "messagesBox";
            messagesBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            messagesBox.Size = new Size(487, 374);
            messagesBox.TabIndex = 4;
            messagesBox.Text = "";
            // 
            // btnCreateChat
            // 
            btnCreateChat.BackColor = Color.LightCoral;
            btnCreateChat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateChat.Location = new Point(12, 403);
            btnCreateChat.Name = "btnCreateChat";
            btnCreateChat.Size = new Size(208, 34);
            btnCreateChat.TabIndex = 5;
            btnCreateChat.Text = "Створити чат";
            btnCreateChat.UseVisualStyleBackColor = false;
            btnCreateChat.Click += btnCreateChat_Click;
            // 
            // userList
            // 
            userList.BackColor = SystemColors.ActiveBorder;
            userList.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            userList.ForeColor = SystemColors.InactiveCaptionText;
            userList.FormattingEnabled = true;
            userList.ItemHeight = 20;
            userList.Location = new Point(719, 53);
            userList.Name = "userList";
            userList.Size = new Size(208, 424);
            userList.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(719, 9);
            label2.Name = "label2";
            label2.Size = new Size(150, 31);
            label2.TabIndex = 7;
            label2.Text = "Користувачі";
            // 
            // btnJoin
            // 
            btnJoin.BackColor = Color.LightCoral;
            btnJoin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnJoin.Location = new Point(12, 443);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(208, 34);
            btnJoin.TabIndex = 8;
            btnJoin.Text = "Приєднатися";
            btnJoin.UseVisualStyleBackColor = false;
            btnJoin.Click += btnJoin_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(619, 18);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Вийти";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += Logout;
            // 
            // btnSendMeesage
            // 
            btnSendMeesage.BackgroundImage = (Image)resources.GetObject("btnSendMeesage.BackgroundImage");
            btnSendMeesage.BackgroundImageLayout = ImageLayout.Stretch;
            btnSendMeesage.Location = new Point(670, 433);
            btnSendMeesage.Name = "btnSendMeesage";
            btnSendMeesage.Size = new Size(43, 43);
            btnSendMeesage.TabIndex = 10;
            btnSendMeesage.UseVisualStyleBackColor = true;
            btnSendMeesage.Click += btnSendMeesage_Click;
            // 
            // cmMessage
            // 
            cmMessage.ImageScalingSize = new Size(20, 20);
            cmMessage.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            cmMessage.Name = "cmMessage";
            cmMessage.Size = new Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(122, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(938, 482);
            Controls.Add(btnSendMeesage);
            Controls.Add(btnLogout);
            Controls.Add(btnJoin);
            Controls.Add(label2);
            Controls.Add(userList);
            Controls.Add(btnCreateChat);
            Controls.Add(messagesBox);
            Controls.Add(tbMessage);
            Controls.Add(label1);
            Controls.Add(chatList);
            Controls.Add(btnProfile);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chat";
            Load += Form1_Load;
            cmMessage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProfile;
        private ListBox chatList;
        private Label label1;
        private TextBox tbMessage;
        private RichTextBox messagesBox;
        private Button btnCreateChat;
        private ListBox userList;
        private Label label2;
        private Button btnJoin;
        private Button btnLogout;
        private Button btnSendMeesage;
        private ContextMenuStrip cmMessage;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
