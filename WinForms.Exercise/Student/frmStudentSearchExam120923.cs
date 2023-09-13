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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinForms.Exercise
{
    public partial class frmStudentSearchExam120923 : Form
    {
        private WinFormsExerciseDbContext dbContext = new();
        public frmStudentSearchExam120923()
        {
            InitializeComponent();

            dgvStudents.AutoGenerateColumns = false;
        }

        private async void frmStudentSearchExam120923_Load(object sender, EventArgs e)
        {
            await LoadStudents();
        }

        private async Task<string> GetSubjectName(int studentId, Subject subject)
        {
            var average = await dbContext.StudentsSubjects
                .Where(x => x.StudentId == studentId && x.Grade >= 6)
                .AverageAsync(x => x.Grade);

            return $"{subject.Name} ({average})";
        }

        private async Task LoadStudents()
        {
            if (string.IsNullOrEmpty(cmbGradeFrom.Text) || string.IsNullOrEmpty(cmbGradeTo.Text))
            {
                return;
            }

            var gradeFrom = int.Parse(cmbGradeFrom.Text);
            var gradeTo = int.Parse(cmbGradeTo.Text);
            var dateFrom = dtpDateFrom.Value;
            var dateTo = dtpDateTo.Value;
            var active = cbActive.Checked;

            var studentSubjects = await dbContext.StudentsSubjects
                .Include(x => x.Student)
                .Include(x => x.Subject)
                .Where(x => x.Grade >= gradeFrom && x.Grade <= gradeTo && x.Student.DateOfBirth >= dateFrom && x.Student.DateOfBirth <= dateTo && x.Student.Active == active)
                .ToListAsync();

            if (studentSubjects.Count == 0)
            {
                MessageBox.Show($"No students found with {(active ? "active" : "not active")} status that have grade from {gradeFrom} to {gradeTo} and that were born in period from {dateFrom:dd/MM/yyyy} and {dateTo:dd/MM/yyyy}");
                return;
            }

            var dtoList = new List<StudentSubjectDto>();

            foreach (var studentSubject in studentSubjects)
            {
                dtoList.Add(new StudentSubjectDto()
                {
                    IndexNumber = studentSubject.Student.IndexNumber,
                    FirstLastName = $"{studentSubject.Student.FirstName} {studentSubject.Student.LastName} ({DateTime.Now.Year - studentSubject.Student.DateOfBirth.Year})",
                    SubjectName = await GetSubjectName(studentSubject.StudentId, studentSubject.Subject),
                    Grade = studentSubject.Grade,
                    Date = studentSubject.Date,
                    Active = studentSubject.Student.Active
                });
            }

            dgvStudents.DataSource = null;
            dgvStudents.DataSource = dtoList;
        }

        private async void cmbGradeFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadStudents();
        }

        private async void cmbGradeTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadStudents();
        }

        private async void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            await LoadStudents();
        }

        private async void dtpDateTo_ValueChanged(object sender, EventArgs e)
        {
            await LoadStudents();
        }

        private async void cbActive_CheckedChanged(object sender, EventArgs e)
        {
            await LoadStudents();
        }
    }

    public class StudentSubjectDto
    {
        public string IndexNumber { get; set; }
        public string FirstLastName { get; set; }
        public string SubjectName { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }
        public bool Active { get; set; }
        public Student Student { get; set; }
    }
}
