using Microsoft.EntityFrameworkCore;
using WinForms.Data;
using WinForms.Data.Context;

namespace WinForms.Exercise
{
    public partial class frmSubjectEdit : Form
    {
        private readonly WinFormsExerciseDbContext dbContext = new();
        public frmSubjectEdit()
        {
            InitializeComponent();

            dgvSubjects.AutoGenerateColumns = false;
        }

        private async void frmSubjectEdit_Load(object sender, EventArgs e)
        {
            await LoadSubjectsAsync();
        }

        private async void btnAddSubject_Click(object sender, EventArgs e)
        {
            var newSubject = new Subject()
            {
                Name = txtSubjectName.Text
            };

            dbContext.Subjects.Add(newSubject);
            await dbContext.SaveChangesAsync();

            await LoadSubjectsAsync();
        }

        private async Task LoadSubjectsAsync()
        {
            dgvSubjects.DataSource = null;
            dgvSubjects.DataSource = await dbContext.Subjects.ToListAsync();
        }
    }
}
