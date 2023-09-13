using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Data;
using WinForms.Data.Context;
using WinForms.Exercise.Extensions;
using WinForms.Exercise.Helpers;

namespace WinForms.Exercise
{
    public partial class frmStudentSubjects : Form
    {
        private readonly WinFormsExerciseDbContext dbContext = new();

        private Student student;
        public frmStudentSubjects(Student student)
        {
            InitializeComponent();

            dgvStudentSubjects.AutoGenerateColumns = false;

            this.student = student;
        }

        private async void frmStudentSubjects_Load(object sender, EventArgs e)
        {
            cmbStudents.SelectedItem = student;

            await LoadStudentsAsync();
            await LoadSubjectsAsync();
            await LoadStudentSubjectsAsync();

        }

        private async Task LoadStudentSubjectsAsync()
        {
            dgvStudentSubjects.DataSource = null;
            dgvStudentSubjects.DataSource = await dbContext.StudentsSubjects
                .Where(x => x.StudentId == student.Id)
                .ToListAsync();
        }

        private async Task LoadSubjectsAsync()
        {
            cmbSubjects.Load(await dbContext.Subjects.ToListAsync());
        }

        private async Task LoadStudentsAsync()
        {
            cmbStudents.Load(await dbContext.Students.ToListAsync(), "Id", "FirstLastName");
        }

        private async void btnAddStudentSubject_Click(object sender, EventArgs e)
        {
            if (!ValidInput()) return;

            var newStudentSubject = new StudentSubject()
            {
                StudentId = student.Id,
                SubjectId = (int)cmbSubjects.SelectedValue!,
                Grade = int.Parse(cmbGrades.Text),
                Date = dtpDate.Value
            };

            dbContext.StudentsSubjects.Add(newStudentSubject);
            await dbContext.SaveChangesAsync();

            await LoadStudentSubjectsAsync();
        }

        private bool ValidInput()
        {
            return ControlValidator.Validate(cmbSubjects, errorProvider, ResourceKeys.MandatoryValue) &&
                ControlValidator.Validate(cmbGrades, errorProvider, ResourceKeys.MandatoryValue);
        }

        private async void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedStudent = cmbStudents.SelectedItem as Student;

            if (selectedStudent.Id == student.Id) return;

            student = selectedStudent;

            await LoadStudentSubjectsAsync();
        }
    }
}
