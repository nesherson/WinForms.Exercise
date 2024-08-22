using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data.Ispit18._02._2021;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;
using WinForms.Exercise.Ispit18._02._2021.Izvjestaj;

namespace WinForms.Exercise.Ispit18._02._2021
{
    public partial class frmCovidTestIB230125 : Form
    {
        private readonly DLWMSDbContext _dbContext = new();
        public frmCovidTestIB230125()
        {
            InitializeComponent();

            dgvStudentCovidTest.AutoGenerateColumns = false;
        }

        private async void frmCovidTestIB230125_Load(object sender, EventArgs e)
        {
            await UcitajStudente();
            await UcitajCovidTestove();
        }

        private async Task UcitajCovidTestove()
        {
            var rezultat = await _dbContext.StudentiCovidTestoviIB230125
                .Include(sct => sct.Student)
                .ToListAsync();

            dgvStudentCovidTest.DataSource = null;
            dgvStudentCovidTest.DataSource = rezultat;

            PrikaziBrojTestova(rezultat);
        }

        private async Task UcitajStudente()
        {
            cmbStudent.PostaviComboBox(await _dbContext.StudentiIB230125.ToListAsync(),
                "Id",
                "Naziv");
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos())
                return;

            var studentId = (int)cmbStudent.SelectedValue;
            var datumTestiranja = dtpDatumTestiranja.Value;

            var postojeciCovidTestovi = await _dbContext.StudentiCovidTestoviIB230125
                .Where(x => x.StudentId == studentId)
                .ToListAsync();

            foreach (var covidTest in postojeciCovidTestovi)
            {
                if (IstiDatum(datumTestiranja, covidTest.Datum))
                {
                    MessageBox.Show("Nije moguce dodati vise testova za isti dan", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            var noviCovidTest = new StudentCovidTestIB230125()
            {
                StudentId = studentId,
                Datum = datumTestiranja,
                Rezultat = cmbRezultatTesta.Text,
                NalazDostavljen = cbNalazDostavljen.Checked
            };

            await _dbContext.StudentiCovidTestoviIB230125.AddAsync(noviCovidTest);
            await _dbContext.SaveChangesAsync();

            await UcitajCovidTestove();
        }

        private void PrikaziBrojTestova(List<StudentCovidTestIB230125> covidTestovi)
        {
            lblBrojTestova.Text = covidTestovi.Count.ToString();
        }

        private bool IstiDatum(DateTime d1, DateTime d2)
        {
            return d1.Year == d2.Year && d1.Month == d2.Month && d1.Day == d2.Day;
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(cmbStudent, errorProvider, "Obavezna vrijednost") &&
                Validator.ProvjeriUnos(dtpDatumTestiranja, errorProvider, "Obavezna vrijednost") &&
                Validator.ProvjeriUnos(cmbRezultatTesta, errorProvider, "Obavezna vrijednost");
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            await GenerisiTestove();
            await UcitajCovidTestove();
        }

        private async Task GenerisiTestove()
        {
            var brojTestova = int.Parse(txtBrojTestova.Text);
            var rand = new Random();
            var studenti = cmbStudent.DataSource as List<StudentIB230125>;

            for (int i = 0; i < brojTestova; i++)
            {
                var noviCovidTest = new StudentCovidTestIB230125()
                {
                    StudentId = studenti[rand.Next(0, studenti.Count)].Id,
                    Datum = DateTime.Now,
                    Rezultat = rand.Next(0, 100) >= 50 ? "Pozitivan" : "Negativan",
                    NalazDostavljen = rand.Next(0, 100) >= 50 ? true : false
                };

                await _dbContext.StudentiCovidTestoviIB230125.AddAsync(noviCovidTest);

            }
            await _dbContext.SaveChangesAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await BrisanjeCovidTestova();
            await UcitajCovidTestove();
        }

        private async Task BrisanjeCovidTestova()
        {
            if (MessageBox.Show("Da li ste sigurni da zelite obrisati sve podatke o COVID testovima?",
                "Potvrda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var covidTestoviZaBrisanja = dgvStudentCovidTest.DataSource as List<StudentCovidTestIB230125>;

                _dbContext.StudentiCovidTestoviIB230125.RemoveRange(covidTestoviZaBrisanja);
                await _dbContext.SaveChangesAsync();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var dtoLista = new List<dtoStudentCovidTest>();

            foreach (var studentCovidTest in dgvStudentCovidTest.DataSource as List<StudentCovidTestIB230125>)
            {
                var dto = new dtoStudentCovidTest()
                {
                    Student = $"{studentCovidTest.Student.Ime} {studentCovidTest.Student.Prezime}",
                    Datum = studentCovidTest.Datum.ToString(),
                    Rezultat = studentCovidTest.Rezultat,
                    NalazDostavljen = studentCovidTest.NalazDostavljen ? "Da" : "Ne"
                };
                dtoLista.Add(dto);
            }


            var frmIzvjestaj = new frmIzvjestajIB230125(dtoLista);
            frmIzvjestaj.ShowDialog();
        }
    }
}
