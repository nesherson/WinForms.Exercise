using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data.Ispit01._02._2024;
using WinForms.Exercise.Data.Ispit22._02._2024;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit22._02._2024
{
    public partial class frmNastavaIB230003 : Form
    {
        private readonly DLWMSDbContext _dbContext;
        private ProstorijaIB230003 _prostorija;

        public frmNastavaIB230003(ProstorijaIB230003 prostorija)
        {
            InitializeComponent();

            dgvNastava.AutoGenerateColumns = false;

            _dbContext = new();
            _prostorija = prostorija;
        }

        private async void frmNastavaIB230003_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOProstoriji();
            await UcitajNastavu();
            await UcitajPredmete();

            cmbDan.SelectedIndex = 0;
            cmbVrijeme.SelectedIndex = 0;
        }

        private async Task UcitajPredmete()
        {
            var podaci = await _dbContext.PredmetiIB230003
                .ToListAsync();

            cmbPredmet.PostaviComboBox(podaci, "Id", "Naziv");
        }

        private async Task UcitajNastavu()
        {
            var podaci = await _dbContext.NastavaIB230003
                .Where(x => x.ProstorijaId == _prostorija.Id)
                .ToListAsync();

            dgvNastava.DataSource = null;
            dgvNastava.DataSource = podaci;
        }

        private void UcitajPodatkeOProstoriji()
        {
            lblImeProstorije.Text = $"{_prostorija.Naziv} - {_prostorija.Oznaka}";
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos())
                return;

            var novaNastava = new NastavaIB230003
            {
                ProstorijaId = _prostorija.Id,
                PredmetId = (int)cmbPredmet.SelectedValue,
                DanOdrzavanja = cmbDan.Text,
                Vrijeme = cmbVrijeme.Text,
                Oznaka = GenerisiOznaku()
            };

            await _dbContext.NastavaIB230003.AddAsync(novaNastava);
            await _dbContext.SaveChangesAsync();
            await UcitajNastavu();
        }

        private string GenerisiOznaku()
        {
            var predmet = cmbPredmet.SelectedItem as PredmetIB230003;
            var dan = cmbDan.Text;
            var vrijeme = cmbVrijeme.Text;

            return $"{predmet.Naziv} :: {dan} :: {vrijeme}";
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(cmbPredmet, errorProvider1, Resursi.Get(Kljucevi.ObaveznaVrijednost)) ||
                Validator.ProvjeriUnos(cmbDan, errorProvider1, Resursi.Get(Kljucevi.ObaveznaVrijednost)) ||
                Validator.ProvjeriUnos(cmbVrijeme, errorProvider1, Resursi.Get(Kljucevi.ObaveznaVrijednost));
        }
    }
}