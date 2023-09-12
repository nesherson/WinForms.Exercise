using Microsoft.EntityFrameworkCore;
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

        private async void frmRegistration_Load(object sender, EventArgs e)
        {
            var test = await dbContext.Users.ToListAsync();
        }
    }
}