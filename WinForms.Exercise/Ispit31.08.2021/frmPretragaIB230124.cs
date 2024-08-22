using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data.Ispit31._08._2021;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit31._08._2021
{
    public partial class frmPretragaIB230124 : Form
    {
        private readonly DLWMSDbContext _dbContext = new();
        private readonly string _samoglasnici = "aeiou";
        private readonly string _suglasnici = "bcćčdđfghjklmnprsštbzž";

        private int _brojSamoglasnika;
        private int _brojSuglasnika;
        private int _brojZnakova;
        public frmPretragaIB230124()
        {
            InitializeComponent();

            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretragaIB230124_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente(List<dtoStudentPretragaIB230124>? studenti = null)
        {
            var rezultat = studenti ?? _dbContext.StudentiIB230124
                .Select(ModelToDto)
                .ToList();

            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = rezultat;

            PrikaziProsjekSvihStudenata(rezultat);
            PrikaziStudentaSaNajvecimProsjekom(rezultat);
        }

        private void PrikaziStudentaSaNajvecimProsjekom(List<dtoStudentPretragaIB230124> studenti)
        {
            dtoStudentPretragaIB230124 studentSaNajvecimProsjekom = studenti.FirstOrDefault();

            foreach (var student in studenti)
            {
                if (student.Prosjek > studentSaNajvecimProsjekom.Prosjek)
                    studentSaNajvecimProsjekom = student;
            }

            if (studenti.Count == 0)
            {
                lblNajveciProsjek.Text = "NOT SET";
            }
            else
            {
                lblNajveciProsjek.Text = studentSaNajvecimProsjekom.ImePrezime;
            }
        }

        private void PrikaziProsjekSvihStudenata(List<dtoStudentPretragaIB230124> studenti)
        {
            decimal suma = 0;

            foreach (var student in studenti)
                suma += student.Prosjek;

            if (studenti.Count == 0)
            {
                lblProsjekPrikazanihOcjena.Text = suma.ToString();
            }
            else
            {
                lblProsjekPrikazanihOcjena.Text = (suma / studenti.Count).ToString();
            }
        }

        private dtoStudentPretragaIB230124 ModelToDto(StudentIB230124 student)
        {
            var polozeniPredmeti = _dbContext.PolozeniPredmetiIB230124
                .Include(x => x.Predmet)
                .Where(x => x.StudentId == student.Id)
                .ToList();

            int sumaOcjena = 0;
            decimal prosjek = 0;

            foreach (var polozeniPredmet in polozeniPredmeti)
                sumaOcjena += polozeniPredmet.Ocjena;


            if (polozeniPredmeti.Count > 0)
                prosjek = sumaOcjena / polozeniPredmeti.Count;

            return new dtoStudentPretragaIB230124()
            {
                StudentId = student.Id,
                ImePrezime = $"{student.Ime} {student.Prezime}",
                PolozeniPredmeti = string.Join(';', polozeniPredmeti.Select(x => x.Predmet.Naziv)),
                BrojPolozenih = polozeniPredmeti.Count,
                Prosjek = prosjek
            };
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            PretraziStudente();
        }

        private void PretraziStudente()
        {
            var pretraga = txtImePrezime.Text.ToLower();

            var rezultat = _dbContext.StudentiIB230124
                .Where(x => x.Ime.ToLower().Contains(pretraga) || x.Prezime.ToLower().Contains(pretraga))
                .Select(ModelToDto)
                .ToList();

            UcitajStudente(rezultat);
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentId = (dgvPretraga.SelectedRows[0].DataBoundItem as dtoStudentPretragaIB230124)
                ?.StudentId;

            if (studentId == null)
                return;

            if (dgvPretraga.CurrentCell is DataGridViewButtonCell)
            {
                var frmScanIspita = new frmScanIspitaIB230124(studentId.Value);
                frmScanIspita.ShowDialog();
            }

        }

        private void btnGenerisiInfo_Click(object sender, EventArgs e)
        {
            var sadrzaj = txtSadrzaj.Text;

            var threadPrebojStavke = new Thread(() => PrebrojStavke(sadrzaj));
            threadPrebojStavke.Start();
        }

        private void PrebrojStavke(string sadrzaj)
        {
            foreach (var karakter in sadrzaj)
            {
                if (_samoglasnici.Contains(karakter))
                    _brojSamoglasnika++;
                else if (_suglasnici.Contains(karakter))
                    _brojSuglasnika++;
                else
                    _brojZnakova++;
            }

            BeginInvoke(PrikaziSadrzaj);
        }

        private void PrikaziSadrzaj()
        {
            lblSamoglasnici.Text = _brojSamoglasnika.ToString();
            lblSuglasnici.Text = _brojSuglasnika.ToString();
            lblZnakovi.Text = _brojZnakova.ToString();
        }
    }
}
