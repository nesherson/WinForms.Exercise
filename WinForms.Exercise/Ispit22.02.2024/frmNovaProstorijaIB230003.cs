using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data.Ispit22._02._2024;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit22._02._2024
{
    public partial class frmNovaProstorijaIB230003 : Form
    {
        private readonly DLWMSDbContext _dbContext;
        private ProstorijaIB230003 _prostorija;

        public frmNovaProstorijaIB230003(ProstorijaIB230003 prostorija = null)
        {
            InitializeComponent();

            _dbContext = new();
            _prostorija = prostorija ?? new ProstorijaIB230003();
        }

        private void frmNovaProstorijaIB230003_Load(object sender, EventArgs e)
        {
            if (_prostorija.Id > 0)
            {
                UcitajPodatkeOProstoriji();
            }
        }

        private void UcitajPodatkeOProstoriji()
        {
            txtNaziv.Text = _prostorija.Naziv;
            txtOznaka.Text = _prostorija.Oznaka;
            txtKapacitet.Text = _prostorija.Kapacitet.ToString();
            pbLogo.Image = _prostorija.Logo?.ToImage();
        }

        private void pbLogo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos())
                return;

            if (!int.TryParse(txtKapacitet.Text, out int kapacitet))
                return;

            _prostorija.Naziv = txtNaziv.Text;
            _prostorija.Oznaka = txtOznaka.Text;
            _prostorija.Kapacitet = int.Parse(txtKapacitet.Text);
            _prostorija.Logo = pbLogo.Image.ToBytes();

            if (_prostorija.Id == 0)
            {
                await _dbContext.ProstorijeIB230003.AddAsync(_prostorija);
            }
            else
            {
                _dbContext.Entry(_prostorija).State = EntityState.Modified;
            }

            await _dbContext.SaveChangesAsync();

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(txtNaziv, errorProvider1, Resursi.Get(Kljucevi.ObaveznaVrijednost)) ||
                Validator.ProvjeriUnos(txtOznaka, errorProvider1, Resursi.Get(Kljucevi.ObaveznaVrijednost)) ||
                Validator.ProvjeriUnos(txtKapacitet, errorProvider1, Resursi.Get(Kljucevi.ObaveznaVrijednost)) ||
                Validator.ProvjeriUnos(pbLogo, errorProvider1, Resursi.Get(Kljucevi.ObaveznaVrijednost));
        }
    }
}