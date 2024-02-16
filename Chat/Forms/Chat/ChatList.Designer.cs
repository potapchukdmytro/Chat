namespace Chat.Forms.Chat
{
    partial class ChatList
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
            lbChatList = new ListBox();
            btnJoin = new Button();
            SuspendLayout();
            // 
            // lbChatList
            // 
            lbChatList.FormattingEnabled = true;
            lbChatList.ItemHeight = 20;
            lbChatList.Location = new Point(12, 12);
            lbChatList.Name = "lbChatList";
            lbChatList.Size = new Size(287, 404);
            lbChatList.TabIndex = 0;
            // 
            // btnJoin
            // 
            btnJoin.BackColor = SystemColors.Control;
            btnJoin.Location = new Point(12, 422);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(287, 36);
            btnJoin.TabIndex = 1;
            btnJoin.Text = "Приєднатися";
            btnJoin.UseVisualStyleBackColor = false;
            btnJoin.Click += btnJoin_Click;
            // 
            // ChatList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 470);
            Controls.Add(btnJoin);
            Controls.Add(lbChatList);
            Name = "ChatList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChatList";
            Load += ChatList_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbChatList;
        private Button btnJoin;
    }
}