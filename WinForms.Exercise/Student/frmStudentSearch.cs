using Microsoft.EntityFrameworkCore;
using WinForms.Data;
using WinForms.Data.Context;

namespace WinForms.Exercise
{
    public partial class frmStudentSearch : Form
    {
        private readonly WinFormsExerciseDbContext dbContext = new();
        public frmStudentSearch()
        {
            InitializeComponent();

            dgvStudents.AutoGenerateColumns = false;
        }

        private void frmStudentSearch_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private async void LoadStudents(List<Student>? students = null)
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = students ?? await dbContext.Students
                .Include(x => x.Gender)
                .Include(x => x.Role)
                .ToListAsync();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedStudent = dgvStudents.SelectedRows[0].DataBoundItem as Student;
            if (selectedStudent == null) return;

            if (dgvStudents.CurrentCell is DataGridViewButtonCell)
            {
                new frmStudentSubjects(selectedStudent).Show();
                return;
            }

            new frmStudentEdit(selectedStudent).Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            new frmStudentEdit().Show();

            LoadStudents();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtSearch.Text;

            var students = await dbContext.Students
                .Where(x => x.FirstName.ToLower().Contains(searchValue) ||
                    x.LastName.ToLower().Contains(searchValue) ||
                    x.IndexNumber.ToLower().Contains(searchValue))
                .ToListAsync();

            LoadStudents(students);
        }
    }
}
