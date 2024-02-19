using Chat.Services;
using Chat.ViewModels.Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat.Forms.Chat
{
    public partial class ChatList : Form
    {
        private readonly UserService userService;
        private readonly ChatService chatService;

        public ChatList(UserService userService, ChatService chatService)
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            this.userService = userService;
            this.chatService = chatService;
        }

        private void ChatList_Load(object sender, EventArgs e)
        {
            var chats = chatService.GetJoinChatList();
            if (chats.Count > 0)
            {
                lbChatList.Items.AddRange(chats.ToArray());
                lbChatList.SelectedIndex = 0;
            }
            else
            {
                lbChatList.Items.Clear();
                lbChatList.Items.Add("Чати не знайдено");
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var item = lbChatList.SelectedItem;

            if(item == null)
            {
                return;
            }

            if(item is ChatVM)
            {
                var chat = (ChatVM)item;

                chatService.AddUser(chat.Id, userService.CurrentUser.Id);
                Close();
            }
        }
    }
}
