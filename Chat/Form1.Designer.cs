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
            userList = new ListBox();
            label2 = new Label();
            btnSendMeesage = new Button();
            cmMessage = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cmChatList = new ContextMenuStrip(components);
            QuitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            чатToolStripMenuItem = new ToolStripMenuItem();
            miCreateChat = new ToolStripMenuItem();
            miJoinChat = new ToolStripMenuItem();
            miQuit = new ToolStripMenuItem();
            cmMessage.SuspendLayout();
            cmChatList.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnProfile
            // 
            btnProfile.BackgroundImage = (Image)resources.GetObject("btnProfile.BackgroundImage");
            btnProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfile.Location = new Point(719, 42);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(207, 160);
            btnProfile.TabIndex = 0;
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
            chatList.Location = new Point(12, 73);
            chatList.Name = "chatList";
            chatList.Size = new Size(208, 404);
            chatList.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
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
            messagesBox.Location = new Point(226, 42);
            messagesBox.Name = "messagesBox";
            messagesBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            messagesBox.Size = new Size(487, 385);
            messagesBox.TabIndex = 4;
            messagesBox.Text = "";
            // 
            // userList
            // 
            userList.BackColor = SystemColors.ActiveBorder;
            userList.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            userList.ForeColor = SystemColors.InactiveCaptionText;
            userList.FormattingEnabled = true;
            userList.ItemHeight = 20;
            userList.Location = new Point(719, 233);
            userList.Name = "userList";
            userList.Size = new Size(208, 244);
            userList.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(719, 205);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 7;
            label2.Text = "Користувачі";
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
            // cmChatList
            // 
            cmChatList.ImageScalingSize = new Size(20, 20);
            cmChatList.Items.AddRange(new ToolStripItem[] { QuitToolStripMenuItem });
            cmChatList.Name = "cmChatList";
            cmChatList.Size = new Size(121, 28);
            // 
            // QuitToolStripMenuItem
            // 
            QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            QuitToolStripMenuItem.Size = new Size(120, 24);
            QuitToolStripMenuItem.Text = "Вийти";
            QuitToolStripMenuItem.Click += QuitToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { чатToolStripMenuItem, miQuit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(938, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // чатToolStripMenuItem
            // 
            чатToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miCreateChat, miJoinChat });
            чатToolStripMenuItem.Name = "чатToolStripMenuItem";
            чатToolStripMenuItem.Size = new Size(47, 24);
            чатToolStripMenuItem.Text = "Чат";
            // 
            // miCreateChat
            // 
            miCreateChat.Name = "miCreateChat";
            miCreateChat.Size = new Size(183, 26);
            miCreateChat.Text = "Створити чат";
            miCreateChat.Click += miCreateChat_Click;
            // 
            // miJoinChat
            // 
            miJoinChat.Name = "miJoinChat";
            miJoinChat.Size = new Size(183, 26);
            miJoinChat.Text = "Приєднатися";
            miJoinChat.Click += miJoinChat_Click;
            // 
            // miQuit
            // 
            miQuit.Name = "miQuit";
            miQuit.Size = new Size(65, 24);
            miQuit.Text = "Вийти";
            miQuit.Click += miQuit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(938, 482);
            Controls.Add(menuStrip1);
            Controls.Add(btnSendMeesage);
            Controls.Add(label2);
            Controls.Add(userList);
            Controls.Add(messagesBox);
            Controls.Add(tbMessage);
            Controls.Add(label1);
            Controls.Add(chatList);
            Controls.Add(btnProfile);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chat";
            Load += Form1_Load;
            cmMessage.ResumeLayout(false);
            cmChatList.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProfile;
        private ListBox chatList;
        private Label label1;
        private TextBox tbMessage;
        private RichTextBox messagesBox;
        private ListBox userList;
        private Label label2;
        private Button btnSendMeesage;
        private ContextMenuStrip cmMessage;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ContextMenuStrip cmChatList;
        private ToolStripMenuItem QuitToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem чатToolStripMenuItem;
        private ToolStripMenuItem miCreateChat;
        private ToolStripMenuItem miJoinChat;
        private ToolStripMenuItem miQuit;
    }
}
