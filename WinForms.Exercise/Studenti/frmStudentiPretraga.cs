using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data;
using WinForms.Exercise.Infrastructure;
using WinForms.Exercise.Predmeti;

namespace WinForms.Exercise.Studenti
{
    public partial class frmStudentiPretraga : Form
    {
        private readonly DLWMSDbContext _dbContext = new();

        public frmStudentiPretraga()
        {
            InitializeComponent();

            dgvStudentiPretraga.AutoGenerateColumns = false;
        }

        private void frmStudentiPretraga_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente(List<Student>? studenti = null)
        {
            dgvStudentiPretraga.DataSource = null;
            dgvStudentiPretraga.DataSource = studenti ?? _dbContext.Studenti
                .Include(x => x.Uloga)
                .Include(x => x.Semestar)
                .ToList();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var rezultat = _dbContext.Studenti
                .Where(FiltrirajStudente)
                .ToList();

            UcitajStudente(rezultat);
        }

        private bool FiltrirajStudente(Student student)
        {
            var pretraga = txtPretraga.Text.ToLower();

            return student.Ime.ToLower().Contains(pretraga) ||
                student.Prezime.ToLower().Contains(pretraga) ||
                student.Indeks.ToLower().Contains(pretraga);
        }

        private void btnStudentNovi_Click(object sender, EventArgs e)
        {
            var frmStudentNovi = new frmStudentNovi();
            frmStudentNovi.ShowDialog();
        }

        private void dgvStudentiPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudent = dgvStudentiPretraga.SelectedRows[0].DataBoundItem as Student;

            if (odabraniStudent == null)
                return;

            if (dgvStudentiPretraga.CurrentCell is DataGridViewButtonCell)
            {
                var frmStudentPolozeniPredmeti = new frmStudentPolozeniPredmeti(odabraniStudent);
                frmStudentPolozeniPredmeti.ShowDialog();
            }
            else
            {
                var frmStudentNovi = new frmStudentNovi(odabraniStudent);
                if (frmStudentNovi.ShowDialog() == DialogResult.OK)
                    UcitajStudente();
            }
        }
    }
}