using AutoMapper;
using Chat.AutomapperProfles;
using Chat.Constants;
using Chat.Entites;
using Chat.Forms.Auth;
using Chat.Forms.Chat;
using Chat.Forms.Profile;
using Chat.Repositories;
using Chat.Services;
using Chat.ViewModels.Chat;
using Chat.ViewModels.Message;
using Chat.ViewModels.User;
using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Chat
{
    public partial class MainForm : Form
    {
        private readonly UserService userService;
        private readonly ChatService chatService;
        private readonly IMapper mapper;

        public MainForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;

            AppDbContext context = new AppDbContext();
            GenericRepository<Guid, UserEntity> userRepository = new GenericRepository<Guid, UserEntity>(context);
            GenericRepository<Guid, ChatEntity> chatRepository = new GenericRepository<Guid, ChatEntity>(context);
            GenericRepository<Guid, MessageEntity> messageRepository = new GenericRepository<Guid, MessageEntity>(context);
            UserChatRepository userChatRepository = new UserChatRepository(context);

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutomapperUserProfile>();
                cfg.AddProfile<AutomapperChatProfile>();
                cfg.AddProfile<AutomapperMessageProfile>();
            });
            mapper = new Mapper(mapperConfig);

            userService = new UserService(userRepository, mapper);
            chatService = new ChatService(chatRepository, mapper, userService, userChatRepository, messageRepository);
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
            LoadUser();
            messagesBox.ContextMenuStrip = cmMessage;

            if (userService.CurrentUser == null)
            {
                AuthForm();
            }

            LoadChats();

            messagesBox.Clear();
            messagesBox.SelectionAlignment = HorizontalAlignment.Center;
            messagesBox.AppendText("Виберіть чат");
        }

        private void Logout(object sender, EventArgs e)
        {
            File.Delete(PathFiles.UserFile);
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
            var chats = chatService.GetAll().ToArray();
            chatList.Items.AddRange(chats);
            chatList.SelectedIndexChanged += ChatListClick;
        }

        private void ChatListClick(object? sender, EventArgs e)
        {
            var chat = (ChatVM)(((ListBox)sender).SelectedItem);

            if (chat != null)
            {
                userList.Items.Clear();
                userList.Items.AddRange(chatService.GetUsers(chat.Id).ToArray());
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
                if(message.UserName == userService.CurrentUser.UserName)
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
            AuthForm authForm = new AuthForm(userService);
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
            if (chatList.SelectedItem != null)
            {
                var chat = (ChatVM)((chatList).SelectedItem);

                var res = chatService.AddUser(chat.Id, userService.CurrentUser.Id);

                if (!res.IsSuccess)
                {
                    MessageBox.Show(res.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ChatListClick(chatList, e);
                }
            }
            else
            {
                MessageBox.Show("Спочатку виберіть чат", "Чат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSendMeesage_Click(object sender, EventArgs e)
        {
            if(chatList.SelectedItem == null)
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
    }
}
