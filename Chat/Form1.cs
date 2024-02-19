using AutoMapper;
using Chat.Configuration;
using Chat.Constants;
using Chat.Forms.Auth;
using Chat.Forms.Chat;
using Chat.Forms.Profile;
using Chat.Services;
using Chat.ViewModels.Chat;
using Chat.ViewModels.Message;
using Chat.ViewModels.User;
using System.Xml.Serialization;

namespace Chat
{
    public partial class MainForm : Form
    {
        private readonly UserService userService;
        private readonly ChatService chatService;
        private readonly LogService logService;
        private readonly IMapper mapper;

        public MainForm(Config config)
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;

            userService = config.userService;
            chatService = config.chatService;
            logService = config.logService;
            mapper = config.mapper;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var profileModel = mapper.Map<ProfileVM>(userService.CurrentUser);
            if (!string.IsNullOrEmpty(userService.CurrentUser.Image))
            {
                profileModel.Image = new Bitmap(Path.Combine(PathFiles.Images, userService.CurrentUser.Image));
                profileModel.Image.Tag = userService.CurrentUser.Image;
            }
            ProfileForm profileForm = new ProfileForm(userService, profileModel);
            profileForm.StartPosition = FormStartPosition.CenterScreen;
            profileForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chatList.SelectedIndexChanged += ChatListClick;
            chatList.ContextMenuStrip = cmChatList;

            LoadUser();
            messagesBox.ContextMenuStrip = cmMessage;

            if (userService.CurrentUser == null)
            {
                AuthForm();
            }

            if (userService.CurrentUser == null)
            {
                Close();
            }

            LoadChats();


            if (chatList.Items.Count > 0)
            {
                chatList.SelectedIndex = 0;
            }
            else
            {
                messagesBox.Clear();
                messagesBox.SelectionAlignment = HorizontalAlignment.Center;
                messagesBox.AppendText("Виберіть або створіть чат");
            }
        }

        private void Logout(object sender, EventArgs e)
        {
            File.Delete(PathFiles.UserFile);
            userService.CurrentUser = null;
            Hide();
            AuthForm();
            Show();
            Form1_Load(sender, e);
        }

        private void LoadUser()
        {
            try
            {
                if (!File.Exists(PathFiles.UserFile))
                {
                    throw new Exception("File not found");
                }

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SaveUserVM));

                using (Stream stream = File.OpenRead(PathFiles.UserFile))
                {

                    var model = (SaveUserVM)xmlSerializer.Deserialize(stream);

                    userService.CurrentUser = userService.GetById(model.Id);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnCreateChat_Click(object sender, EventArgs e)
        {
            var model = new CreateChatVM();

            CreateChatForm form = new CreateChatForm(model);
            form.ShowDialog();

            if (model.Title != null)
            {
                model.UserId = userService.CurrentUser.Id;
                var res = chatService.CreateChat(model);

                if (!res.IsSuccess)
                {
                    MessageBox.Show(res.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LoadChats();
                }
            }
        }

        private void LoadChats()
        {
            chatList.Items.Clear();
            var chats = chatService.GetAll(userService.CurrentUser.Id).ToArray();
            if (chats.Count() > 0)
            {
                chatList.Items.AddRange(chats);
                chatList.SelectedIndex = 0;
            }
        }

        private void ChatListClick(object? sender, EventArgs e)
        {
            var chat = (ChatVM)(((ListBox)sender).SelectedItem);

            if (chat != null)
            {
                userList.Items.Clear();
                var users = chatService.GetUsers(chat.Id).ToArray();
                users.FirstOrDefault(u => u.Id == chat.Owner).Username += "\tвласник";
                userList.Items.AddRange(users);
                UpdateMessagesList(chat.Id);
            }
        }

        private void UpdateMessagesList(Guid chatId)
        {
            var messages = chatService.GetMessages(chatId);

            messagesBox.Clear();

            if (messages.Count == 0)
            {
                messagesBox.AppendText("В даному чаті ще немає повідомлень");
                return;
            }

            messages.Sort((m1, m2) => m1.Date.CompareTo(m2.Date));

            foreach (var message in messages)
            {
                messagesBox.DeselectAll();
                if (message.UserName == userService.CurrentUser.UserName)
                {
                    messagesBox.SelectionAlignment = HorizontalAlignment.Right;
                    messagesBox.SelectionFont = new Font(messagesBox.SelectionFont.FontFamily, 9.0f, FontStyle.Bold);
                    messagesBox.AppendText($"{message.UserName}: {message.Text}\n");
                    messagesBox.SelectionFont = new Font(messagesBox.SelectionFont.FontFamily, 6.0f, FontStyle.Bold | FontStyle.Italic);
                    messagesBox.AppendText($"{message.Date.ToShortDateString()}\n");
                }
                else
                {
                    messagesBox.SelectionAlignment = HorizontalAlignment.Left;
                    messagesBox.AppendText($"{message.UserName}: {message.Text}\n");
                    messagesBox.SelectionFont = new Font(messagesBox.SelectionFont.FontFamily, 6.0f, FontStyle.Italic);
                    messagesBox.AppendText($"{message.Date.ToShortDateString()}\n");
                }
            }
        }

        private void AuthForm()
        {
            AuthForm authForm = new AuthForm(userService, logService);
            authForm.ShowDialog();

            if (userService.CurrentUser == null)
            {
                Close();
            }
            else
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SaveUserVM));

                using (Stream stream = File.Create(PathFiles.UserFile))
                {
                    var model = new SaveUserVM
                    {
                        Id = userService.CurrentUser.Id
                    };
                    xmlSerializer.Serialize(stream, model);
                }
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            ChatList chatList = new ChatList(userService, chatService);
            chatList.ShowDialog();
            LoadChats();
        }

        private void btnSendMeesage_Click(object sender, EventArgs e)
        {
            if (chatList.SelectedItem == null)
            {
                tbMessage.Text = string.Empty;
                return;
            }

            var message = tbMessage.Text.Trim();
            if (string.IsNullOrEmpty(message))
            {
                tbMessage.Text = string.Empty;
                return;
            }

            var chat = (ChatVM)chatList.SelectedItem;

            var model = new CreateMessageVM
            {
                Id = Guid.NewGuid(),
                ChatId = chat.Id,
                UserId = userService.CurrentUser.Id,
                Text = tbMessage.Text
            };

            chatService.AddMessage(model);
            tbMessage.Text = string.Empty;
            UpdateMessagesList(chat.Id);
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSendMeesage_Click(sender, e);
            }
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var chat = (ChatVM)chatList.SelectedItem;

            if(chat != null)
            {
                chatService.Quit(chat.Id, userService.CurrentUser.Id);
                LoadChats();
            }
        }
    }
}
