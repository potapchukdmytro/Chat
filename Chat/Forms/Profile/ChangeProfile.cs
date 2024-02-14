using AutoMapper;
using Chat.Validation;
using Chat.ViewModels.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat.Forms.Profile
{
    public partial class ChangeProfile : Form
    {
        private ProfileVM model;

        public ChangeProfile(ProfileVM model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void ChangeProfile_Load(object sender, EventArgs e)
        {
            tbEmail.Text = model.Email;
            tbLogin.Text = model.UserName;
            tbName.Text = model.FirstName;
            tbSurname.Text = model.LastName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Email = tbEmail.Text;
            model.UserName = tbLogin.Text;
            model.FirstName = tbName.Text;
            model.LastName = tbSurname.Text;

            ProfileValidator validator = new ProfileValidator();
            var res = validator.Validate(model);

            if(res.IsValid)
            {
                Close();
            }
            else
            {
                MessageBox.Show(res.Errors[0].ErrorMessage, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
