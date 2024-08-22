using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data;
using WinForms.Exercise.Data.Ispit18._02._2021;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit18._02._2021
{
    public partial class frmPretragaIB230125 : Form
    {
        private readonly DLWMSDbContext _dbContext = new();
        public frmPretragaIB230125()
        {
            InitializeComponent();

            dgvPretraga.AutoGenerateColumns = false;
        }



        private void frmPretragaIB230125_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke(List<PolozeniPredmetIB230125>? polozeniPredmeti = null)
        {
            var rezultat = polozeniPredmeti ?? _dbContext.PolozeniPredmetiIB230125
                .Include(s => s.Student)
                .Include(s => s.Student.Spol)
                .ToList();

            var studenti = new List<StudentIB230125>();

            foreach (var polozeniPredmet in rezultat)
            {
                if (!studenti.Any(x => x.Id == polozeniPredmet.StudentId))
                    studenti.Add(polozeniPredmet.Student);
            }

            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = studenti;

            if (rezultat?.Count > 0)
                PrikaziDetalje(rezultat, studenti);
        }

        private void PrikaziDetalje(List<PolozeniPredmetIB230125> polozeniPredmeti, List<StudentIB230125> studenti)
        {
            decimal sumaOcjena = 0;

            foreach (var polozeniPredmet in polozeniPredmeti)
            {
                sumaOcjena += polozeniPredmet.Ocjena;
            }

            decimal prosjek = sumaOcjena / polozeniPredmeti.Count;

            lblBrojStudenata.Text = studenti.Count.ToString();
            lblProsjecnaOcjena.Text = prosjek.ToString("n");
        }

        private void FiltrirajStudente()
        {
            if (!ValidanUnos())
                return;



            var polozeniPredmeti = _dbContext.PolozeniPredmetiIB230125
                .Include(s => s.Student)
                .Include(s => s.Student.Spol)
                .Where(Filtriraj)
                .ToList();

            UcitajPodatke(polozeniPredmeti);
        }

        private bool Filtriraj(PolozeniPredmetIB230125 polozeniPredmet)
        {
            var datumOd = dtpOd.Value;
            var datumDo = dtpDo.Value;
            var znak = cmbZnak.Text;
            var ocjena = int.Parse(cmbOcjena.Text);

            return znak switch
            {
                "=" => polozeniPredmet.DatumPolaganja >= datumOd && polozeniPredmet.DatumPolaganja <= datumDo && polozeniPredmet.Ocjena == ocjena,
                "<" => polozeniPredmet.DatumPolaganja >= datumOd && polozeniPredmet.DatumPolaganja <= datumDo && polozeniPredmet.Ocjena < ocjena,
                "<=" => polozeniPredmet.DatumPolaganja >= datumOd && polozeniPredmet.DatumPolaganja <= datumDo && polozeniPredmet.Ocjena <= ocjena,
                ">" => polozeniPredmet.DatumPolaganja >= datumOd && polozeniPredmet.DatumPolaganja <= datumDo && polozeniPredmet.Ocjena > ocjena,
                ">=" => polozeniPredmet.DatumPolaganja >= datumOd && polozeniPredmet.DatumPolaganja <= datumDo && polozeniPredmet.Ocjena >= ocjena,
                _ => false,
            };
        }


        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(dtpOd, errorProvider, "Obavezna vrijednost") &&
                Validator.ProvjeriUnos(dtpDo, errorProvider, "Obavezna vrijednost") &&
                Validator.ProvjeriUnos(cmbZnak, errorProvider, "Obavezna vrijednost") &&
                Validator.ProvjeriUnos(cmbOcjena, errorProvider, "Obavezna vrijednost");
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            FiltrirajStudente();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            FiltrirajStudente();
        }



        private void cmbZnak_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajStudente();
        }

        private void cmbOcjena_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajStudente();
        }

        private void btnCovid_Click(object sender, EventArgs e)
        {
            var frmCovidTest = new frmCovidTestIB230125();
            frmCovidTest.ShowDialog();
        }
    }
}
