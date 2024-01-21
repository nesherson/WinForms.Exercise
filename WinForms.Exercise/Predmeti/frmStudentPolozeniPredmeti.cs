using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data;
using WinForms.Exercise.Data.DTO;
using WinForms.Exercise.Infrastructure;
using WinForms.Exercise.Izvjestaji;

namespace WinForms.Exercise.Predmeti
{
    public partial class frmStudentPolozeniPredmeti : Form
    {
        private readonly DLWMSDbContext _dbContext = new();

        private Student _student;

        public frmStudentPolozeniPredmeti(Student student)
        {
            InitializeComponent();

            dgvPolozeniPredmeti.AutoGenerateColumns = false;

            _student = student;
        }

        private void frmStudentPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentu();
            UcitajPredmete();
            UcitajPolozenePredmete();
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = _dbContext.PolozeniPredmeti
                .Include(pp => pp.Predmet)
                .Where(x => x.StudentId == _student.Id)
                .ToList();
        }

        private void UcitajPredmete()
        {
            cmbPredmet.PostaviComboBox(_dbContext.Predmeti.ToList());
        }

        private void UcitajPodatkeOStudentu()
        {
            lblImePrezime.Text = $"{_student.Ime} {_student.Prezime}";
            lblBrojIndeksa.Text = _student.Indeks;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var izabraniPredmet = cmbPredmet.SelectedItem as Predmet;
            var noviPolozeniPredmet = new PolozeniPredmet()
            {
                StudentId = _student.Id,
                PredmetId = izabraniPredmet.Id,
                Ocjena = int.Parse(cmbOcjena.Text),
                DatumPolaganja = dtpDatumPolaganja.Value
            };

            _dbContext.PolozeniPredmeti.Add(noviPolozeniPredmet);
            _dbContext.SaveChanges();

            UcitajPolozenePredmete();
        }

        private void btnUvjerenje_Click(object sender, EventArgs e)
        {
            var polozeniPredmeti = _dbContext.PolozeniPredmeti
                .Include(pp => pp.Predmet)
                .Where(x => x.StudentId == _student.Id)
                .ToList();

            var dto = new dtoStudentUvjerenje
            {
                ImePrezime = $"{_student.Ime} {_student.Prezime}",
                BrojIndeksa = _student.Indeks,
                Svrha = "REGULISANJE STIPENDIJE",
                Status = "REDOVAN",
                AkademskaGodina = $"{DateTime.Now.Year - 1}/{DateTime.Now.Year}",
                PolozeniPredmeti = polozeniPredmeti
            };

            new frmUvjerenje(dto).ShowDialog();
        }
    }
}