using Microsoft.EntityFrameworkCore;
using WinForms.Data.Context;
using WinForms.Exercise.Helpers;

namespace WinForms.Exercise.Auth
{
    public partial class frmLogin : Form
    {
        private readonly WinFormsExerciseDbContext dbContext = new();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmRegistration().Show();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidInput()) return;

            var email = txtEmail.Text;
            var password = txtPassword.Text;

            var user = await dbContext.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);

            if (user == null)
            {
                MessageBox.Show(ResourceGetter.Get(ResourceKeys.IncorrectCredentials), ResourceKeys.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            App.CurrentUser = user;

            ResetForm();
            Hide();

            var frmMain = new frmMain();

            if (frmMain.ShowDialog() == DialogResult.OK)
            {
                Show();
            }

        }

        private void ResetForm()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private bool ValidInput()
        {
            return ControlValidator.Validate(txtEmail, errorProvider, ResourceKeys.MandatoryValue) &&
                ControlValidator.Validate(txtPassword, errorProvider, ResourceKeys.MandatoryValue);
        }
    }
}
