using WinForms.Exercise.Glavna;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Auth
{
    public partial class frmPrijava : Form
    {
        private readonly DLWMSDbContext _dbContext = new();

        public frmPrijava()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmRegistracija = new frmRegistracija();
            frmRegistracija.ShowDialog();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos())
                return;

            var korisnickoIme = txtKorisnickoIme.Text;
            var lozinka = txtLozinka.Text;

            var korisnik = _dbContext.Korisnici
                .FirstOrDefault(x => x.KorisnickoIme == korisnickoIme && x.Lozinka == lozinka);

            if (korisnik == null)
            {
                MessageBox.Show(Resursi.Get(Kljucevi.NeispravniPodaci), Resursi.Get(Kljucevi.Upozorenje), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Aplikacija.PrijavljeniKorisnik = korisnik;

            Hide();

            var frmGlavna = new frmGlavna();

            if (frmGlavna.ShowDialog() == DialogResult.OK)
                Show();
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(txtKorisnickoIme, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost)) &&
                Validator.ProvjeriUnos(txtLozinka, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost));
        }
    }
}