using WinForms.Exercise.Helpers;

namespace WinForms.Exercise.Auth
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidInput()) return;
        }

        private bool ValidInput()
        {
            return ControlValidator.Validate(txtUsername, errorProvider, ResourceKeys.MandatoryValue) &&
                ControlValidator.Validate(txtEmail, errorProvider, ResourceKeys.MandatoryValue) &&
                ControlValidator.Validate(txtPassword, errorProvider, ResourceKeys.MandatoryValue);
        }
    }
}