using Chat.Services;
using Chat.ViewModels.Auth;

namespace Chat.Forms.Auth
{
    public partial class AuthForm : Form
    {
        private readonly UserService userService;
        private readonly LogService logService;

        public AuthForm(UserService userService, LogService logService)
        {
            InitializeComponent();

            dtBirthdate.MaxDate = DateTime.Now;
            this.userService = userService;
            this.logService = logService;
            panelRegister.Visible = false;
            panelLogin.Visible = true;
            Text = "Вхід";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new RegisterVM
                {
                    Email = tbEmail.Text,
                    UserName = tbLogin.Text,
                    Password = tbPassword.Text,
                    ConfirmPassword = tbConfirmPassword.Text,
                    Birthday = dtBirthdate.Value,
                    FirstName = tbName.Text,
                    LastName = tbSurname.Text,
                    Role = "User"
                };

                var res = userService.Register(model);

                if (!res.IsSuccess)
                {
                    logService.AddLog($"{model.Email}: {res.Message}", Enum.GetName(LogTypes.RegisterError));
                    MessageBox.Show(res.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    logService.AddLog($"Email: {model.Email}, Username: {model.UserName} registered", Enum.GetName(LogTypes.RegisterSuccess));
                    Close();
                }
            }
            catch (Exception ex)
            {
                logService.AddLog($"{ex.Message}", Enum.GetName(LogTypes.Exception));
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginVM model = new LoginVM
                {
                    Login = tbLoginEmail.Text,
                    Password = tbLoginPassword.Text
                };

                var res = userService.Login(model);

                if (!res.IsSuccess)
                {
                    logService.AddLog($"{model.Login}: {res.Message}", Enum.GetName(LogTypes.LoginError));
                    MessageBox.Show(res.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    logService.AddLog($"{model.Login} logined", Enum.GetName(LogTypes.LoginSuccess));
                    Close();
                }
            }
            catch (Exception ex)
            {
                logService.AddLog($"{ex.Message}", Enum.GetName(LogTypes.Exception));
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
