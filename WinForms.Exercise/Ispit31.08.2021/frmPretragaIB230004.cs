using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data.Ispit31._08._2021;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit31._08._2021
{
    public partial class frmPretragaIB230004 : Form
    {
        private readonly DLWMSDbContext _dbContext;
        private readonly string samoglasnici = "aeiou";
        private readonly string znakovi = "!?<>.,*";

        private int _brojSamoglasnika = 0;
        private int _brojSuglasnika = 0;
        private int _brojZnakova = 0;

        public frmPretragaIB230004()
        {
            InitializeComponent();

            dgvStudenti.AutoGenerateColumns = false;

            _dbContext = new();
        }

        private void frmPretragaIB230004_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente(List<StudentPretragaIB230004DTO>? studenti = null)
        {
            var podaci = studenti ?? _dbContext.StudentiIB230004
                .Include(s => s.PolozeniPredmetIB230004).ThenInclude(pp => pp.Predmet)
                .Select(GetDto)
                .ToList();

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = podaci;

            if (podaci.Count == 0)
                return;

            lblProsjekOcjena.Text = $"Prosjek prikazanih ocjena: {GetProsjekPrikazanihOcjena(podaci)}";
            lblNajveciProsjek.Text = $"Najveći prosjek ostvario: {GetNajveciProsjek(podaci)}";
        }

        private string GetNajveciProsjek(List<StudentPretragaIB230004DTO> studenti)
        {
            if (studenti.Count == 0)
                return "0";

            return studenti.MaxBy(x => float.Parse(x.Prosjek)).ImePrezime;
        }

        private string GetProsjekPrikazanihOcjena(List<StudentPretragaIB230004DTO> studenti)
        {
            if (studenti.Count == 0)
                return "<NOT SET>";

            return (studenti.Sum(x => float.Parse(x.Prosjek)) / studenti.Count).ToString();
        }

        private StudentPretragaIB230004DTO GetDto(StudentIB230004 student)
        {
            var brojPolozenih = student.PolozeniPredmetIB230004.Count;
            var polozeniPredmeti = string.Join("; ", student.PolozeniPredmetIB230004.Select(x => x.Predmet.Naziv));
            var prosjek = student.PolozeniPredmetIB230004.Sum(x => x.Ocjena) / (float)brojPolozenih;

            return new StudentPretragaIB230004DTO
            {
                ImePrezime = $"{student.Ime} {student.Prezime}",
                PolozeniPredmeti = polozeniPredmeti,
                Prosjek = string.Format("{0:0.00}", prosjek),
                BrojPolozenih = brojPolozenih,
                Student = student
            };
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            var imePrezime = txtImePrezime.Text.ToLower();
            var podaci = _dbContext.StudentiIB230004
                .Include(s => s.PolozeniPredmetIB230004).ThenInclude(pp => pp.Predmet)
                .Where(x => x.Ime.ToLower().Contains(imePrezime) || x.Prezime.ToLower().Contains(imePrezime))
                .Select(GetDto)
                .ToList();

            UcitajStudente(podaci);
        }

        private async void btnGenerisiInfo_Click(object sender, EventArgs e)
        {
            var sadrzaj = txtSadrzaj.Text;
            if (string.IsNullOrEmpty(sadrzaj))
                return;

            await Task.Run(() => GenerisiInfo(sadrzaj.ToLower()));
        }

        private void GenerisiInfo(string sadrzaj)
        {
            for (int i = 0; i < sadrzaj.Length; i++)
            {
                if (samoglasnici.Contains(sadrzaj[i]))
                    _brojSamoglasnika++;
                else if (!samoglasnici.Contains(sadrzaj[i]) && !znakovi.Contains(sadrzaj[i]))
                    _brojSuglasnika++;
                else if (znakovi.Contains(sadrzaj[i]))
                    _brojZnakova++;

                BeginInvoke(PrikaziSadrzaj);
            }
        }

        private void PrikaziSadrzaj()
        {
            lblBrojSamoglasnika.Text = $"Samoglasnika: {_brojSamoglasnika}";
            lblBrojSuglasnika.Text = $"Suglasnika: {_brojSuglasnika}";
            lblBrojZnakova.Text = $"Znakova(!,?,<,>,*): {_brojZnakova}";
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaStavka = dgvStudenti.SelectedRows[0].DataBoundItem as StudentPretragaIB230004DTO;

            if (odabranaStavka == null)
                return;

            if (dgvStudenti.CurrentCell is DataGridViewButtonCell)
                new frmScanIspitaIB230004(odabranaStavka.Student).ShowDialog();
        }
    }
}