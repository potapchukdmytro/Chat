using Chat.Services;
using Chat.ViewModels.Auth;

namespace Chat.Forms.Auth
{
    public partial class AuthForm : Form
    {
        private readonly UserService userService;
        private State state;

        public AuthForm(UserService userService)
        {
            InitializeComponent();

            dtBirthdate.MaxDate = DateTime.Now;
            this.userService = userService;
            state = State.GetInstance();
            panelRegister.Visible = false;
            panelLogin.Visible = true;
            Text = "Вхід";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var model = new RegisterVM
            {
                Email = tbEmail.Text,
                UserName = tbLogin.Text,
                Password = tbPassword.Text,
                ConfirmPassword = tbConfirmPassword.Text,
                Birthday = dtBirthdate.Value,
                FirstName = tbName.Text,
                LastName = tbSurname.Text
            };

            var res = userService.Register(model);

            if(!res.IsSuccess)
            {
                MessageBox.Show(res.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginVM model = new LoginVM
            {
                Login = tbLoginEmail.Text,
                Password = tbLoginPassword.Text
            };

            var res = userService.Login(model);

            if(!res.IsSuccess)
            {
                MessageBox.Show(res.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }

        private void btnToRegister_Click(object sender, EventArgs e)
        {
            Text = "Зареєструватися";
            panelRegister.Visible = true;
            panelLogin.Visible = false;
            tbEmail.Text = tbLoginEmail.Text;
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
            tbName.Text = "";
            tbSurname.Text = "";
            tbLogin.Text = "";
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            Text = "Увійти";
            panelRegister.Visible = false;
            panelLogin.Visible = true;
            tbLoginEmail.Text = tbEmail.Text;
            tbLoginPassword.Text = "";
        }
    }
}
