using WinForms.Exercise.Data;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Auth
{
    public partial class frmRegistracija : Form
    {
        private readonly DLWMSDbContext _dbContext = new();

        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos())
                return;

            var noviKorisnik = new Korisnik()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                KorisnickoIme = txtKorisnickoIme.Text,
                Email = txtEmail.Text,
                Lozinka = txtLozinka.Text
            };

            _dbContext.Korisnici.Add(noviKorisnik);
            _dbContext.SaveChanges();

            MessageBox.Show(Resursi.Get(Kljucevi.KorisnikKreiranUspjeh),
                Resursi.Get(Kljucevi.KorisnikKreiranUspjeh),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Close();
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(txtIme, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost)) &&
                Validator.ProvjeriUnos(txtPrezime, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost)) &&
                Validator.ProvjeriUnos(txtKorisnickoIme, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost)) &&
                Validator.ProvjeriUnos(txtEmail, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost)) &&
                Validator.ProvjeriUnos(txtLozinka, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost));
        }
    }
}