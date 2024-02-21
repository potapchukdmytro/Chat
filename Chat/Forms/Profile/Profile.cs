using Chat.Constants;
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

            if(userService.UserImage != null)
            {
                pictureBox1.BackgroundImage = null;
                pictureBox1.Image = userService.UserImage;
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
                    model.Image = file.Name;
                    pictureBox1.Image = new Bitmap(file.FullName);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(model.Image != userService.CurrentUser.Image)
            {
                if(userService.UserImage != null)
                {
                    userService.UserImage.Dispose();
                    File.Delete(Path.Combine(PathFiles.Images, userService.CurrentUser.Image));
                }
                
                string extension = model.Image.Substring(model.Image.LastIndexOf('.'));
                string imageName = Guid.NewGuid().ToString() + extension;

                pictureBox1.Image.Save(Path.Combine(PathFiles.Images, imageName));
                userService.UserImage = new Bitmap(Path.Combine(PathFiles.Images, imageName));
                model.Image = imageName;
            }

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
