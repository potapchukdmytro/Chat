using Chat.ViewModels.Chat;

namespace Chat.Forms.Chat
{
    public partial class CreateChatForm : Form
    {
        private CreateChatVM model;

        public CreateChatForm(CreateChatVM model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            model.Title = textBox1.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            model.Title = null;
            Close();
        }
    }
}
