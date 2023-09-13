using Microsoft.EntityFrameworkCore;
using WinForms.Data;
using WinForms.Data.Context;
using WinForms.Exercise.Extensions;
using WinForms.Exercise.Helpers;

namespace WinForms.Exercise
{
    public partial class frmStudentEdit : Form
    {
        private readonly WinFormsExerciseDbContext dbContext = new();

        private Student student;
        public frmStudentEdit(Student? student = null)
        {
            InitializeComponent();

            dgvUserRoles.AutoGenerateColumns = false;

            this.student = student ?? new Student();
        }

        private void frmStudentEdit_Load(object sender, EventArgs e)
        {
            LoadGenders();
            LoadRoles();

            if (student.Id == 0)
            {
                lblAddEditStudent.Text = "Add student";
            }
            else
            {
                lblAddEditStudent.Text = $"Edit student: {student.FirstName} {student.LastName}";

                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtEmail.Text = student.Email;
                dtpDateOfBirth.Value = student.DateOfBirth;
                cmbGenders.SelectedValue = student.GenderId;
                txtIndexNumber.Text = student.IndexNumber;
                txtPassword.Text = student.Password;
                cbActive.Checked = student.Active;
                pbStudentImage.Image = ImageHelper.ToImage(student.Image);

                LoadUserRoles();
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            if (ofdUserImage.ShowDialog() == DialogResult.OK)
            {
                var path = ofdUserImage.FileName;
                tslImagePath.Text = path;

                pbStudentImage.Image = Image.FromFile(path);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Email = txtEmail.Text;
            student.DateOfBirth = dtpDateOfBirth.Value;
            student.GenderId = (int)cmbGenders.SelectedValue;
            student.Password = txtPassword.Text;
            student.IndexNumber = txtIndexNumber.Text;
            student.Active = cbActive.Checked;
            student.Image = ImageHelper.ToBytes(pbStudentImage.Image);

            var messageKey = ResourceKeys.StudentAddSuccess;

            if (student.Id == 0)
            {
                await dbContext.Students.AddAsync(student);
            }
            else
            {
                dbContext.Entry(student).State = EntityState.Modified;
                messageKey = ResourceKeys.StudentUpdateSuccess;
            }

            await dbContext.SaveChangesAsync();

            MessageBox.Show(ResourceGetter.Get(messageKey, $"{student.FirstName} {student.LastName}", student.IndexNumber),
                ResourceGetter.Get(ResourceKeys.Information),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Close();
        }

        private async void LoadGenders()
        {
            cmbGenders.Load(await dbContext.Genders.ToListAsync());
        }

        private async void LoadRoles()
        {
            cmbRoles.Load(await dbContext.Roles.ToListAsync());
        }

        private void LoadUserRoles()
        {
            dgvUserRoles.DataSource = null;
            dgvUserRoles.DataSource = student.Role.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!RoleValidInput()) return;

            var selectedRole = cmbRoles.SelectedItem as Role;
            if (IsRoleAdded(selectedRole)) return;

            student.Role.Add(selectedRole);

            LoadUserRoles();
        }

        private bool RoleValidInput()
        {
            return ControlValidator.Validate(cmbRoles, errorProvider, ResourceKeys.MandatoryValue);
        }

        private bool IsRoleAdded(Role selectedRole)
        {
            return student.Role.Any(x => x.Id == selectedRole.Id);
        }


    }
}
