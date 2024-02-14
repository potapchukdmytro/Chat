using Chat.Services;
using Chat.ViewModels.User;

namespace Chat.Forms.Profile
{
    public partial class ProfileForm : Form
    {
        private readonly UserService userService;
        private readonly ProfileVM model;

        public ProfileForm(UserService userService, ProfileVM model)
        {
            InitializeComponent();
            this.userService = userService;
            this.model = model;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lbUsername.Text = model.UserName;
            lbEmail.Text = model.Email;
            lbName.Text = string.IsNullOrEmpty(model.FirstName) ? "Ім'я" : model.FirstName;
            lbSurname.Text = string.IsNullOrEmpty(model.LastName) ? "Прізвище" : model.LastName;
            if (model.Image != null)
            {
                pictureBox1.BackgroundImage = null;
                pictureBox1.Image = model.Image;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                FileInfo file = new FileInfo(dialog.FileName);

                if (file.Extension != ".jpg" && file.Extension != ".png")
                {
                    MessageBox.Show("Тільки png або jpg", "Помилка формату", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pictureBox1.Image?.Dispose();
                    model.Image?.Dispose();

                    using (Stream stream = dialog.OpenFile())
                    {
                        Image image = new Bitmap(stream);
                        pictureBox1.Image = image;
                        image.Tag = $"{Guid.NewGuid()}{file.Extension}";
                        pictureBox1.BackgroundImage = null;
                        model.Image = image;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var res = userService.ProfileChange(model);

            if (!res.IsSuccess)
            {
                MessageBox.Show(res.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ChangeProfile changeProfile = new ChangeProfile(model);
            changeProfile.StartPosition = FormStartPosition.CenterScreen;
            changeProfile.ShowDialog();

            lbUsername.Text = model.UserName;
            lbEmail.Text = model.Email;
            lbName.Text = string.IsNullOrEmpty(model.FirstName) ? "Ім'я" : model.FirstName;
            lbSurname.Text = string.IsNullOrEmpty(model.LastName) ? "Прізвище" : model.LastName;
        }
    }
}
