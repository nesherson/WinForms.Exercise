using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data.Ispit01._02._2024;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit01._02._2024
{
    public partial class frmPretragaIB230002 : Form
    {
        private readonly DLWMSDbContext _dbContext;

        public frmPretragaIB230002()
        {
            InitializeComponent();

            _dbContext = new();

            dgvStudenti.AutoGenerateColumns = false;
        }

        private async void frmPretragaIB230002_Load(object sender, EventArgs e)
        {
            await UcitajDrzave();
            await UcitajGradove();
            await UcitajStudente();
        }

        private async Task UcitajDrzave()
        {
            var podaci = await _dbContext.DrzaveIB230002
                .ToListAsync();

            cmbDrzava.PostaviComboBox(podaci, "Id", "Naziv");
        }

        private async Task UcitajGradove()
        {
            var drzavaId = (int)cmbDrzava.SelectedValue;
            var podaci = await _dbContext.GradoviIB230002
                .Where(x => x.DrzavaId == drzavaId)
                .ToListAsync();

            cmbGrad.PostaviComboBox(podaci, "Id", "Naziv");
        }

        private async Task UcitajStudente()
        {
            if (cmbDrzava.SelectedValue == null || cmbGrad.SelectedValue == null)
                return;

            var drzavaId = (int)cmbDrzava.SelectedValue;
            var gradId = (int)cmbGrad.SelectedValue;

            var podaci = (await _dbContext.StudentiIB230002
                .Include(x => x.PolozeniPredmetIB230002)
                .Include(x => x.MjestoRodjenja).ThenInclude(y => y.Drzava)
                .Where(x => x.MjestoRodjenjaId == gradId)
                .ToListAsync())
                .Select(GetDto)
                .ToList();

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = podaci;
        }

        private StudentPretragaIB230002DTO GetDto(StudentIB230002 student)
        {
            float prosjek = 0;

            if (student.PolozeniPredmetIB230002.Count > 0)
            {
                prosjek = (float)student
                .PolozeniPredmetIB230002.Sum(x => x.Ocjena) / student.PolozeniPredmetIB230002.Count;
            }

            return new StudentPretragaIB230002DTO
            {
                Ime = student.Ime,
                Prezime = student.Prezime,
                Grad = student.MjestoRodjenja.Naziv,
                Drzava = student.MjestoRodjenja.Drzava.Naziv,
                Prosjek = prosjek
            };
        }

        private async void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UcitajGradove();
        }

        private async void cmbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UcitajStudente();
        }
    }
}