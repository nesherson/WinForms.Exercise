using Microsoft.EntityFrameworkCore;
using WinForms.Data.Auth;
using WinForms.Data.Context;
using WinForms.Exercise.Helpers;

namespace WinForms.Exercise.Auth
{
    public partial class frmRegistration : Form
    {
        private readonly WinFormsExerciseDbContext dbContext = new();

        public frmRegistration()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidInput()) return;

            var newUser = new User()
            {
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            dbContext.Users.Add(newUser);
            await dbContext.SaveChangesAsync();

            MessageBox.Show(ResourceGetter.Get(ResourceKeys.UserAddSuccess, newUser.Username), ResourceKeys.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private bool ValidInput()
        {
            return ControlValidator.Validate(txtUsername, errorProvider, ResourceKeys.MandatoryValue) &&
                ControlValidator.Validate(txtEmail, errorProvider, ResourceKeys.MandatoryValue) &&
                ControlValidator.Validate(txtPassword, errorProvider, ResourceKeys.MandatoryValue);
        }


    }
}