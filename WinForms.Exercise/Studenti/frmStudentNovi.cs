using WinForms.Exercise.Data;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Studenti
{
    public partial class frmStudentNovi : Form
    {
        private readonly DLWMSDbContext _dbContext = new();
        private Student _student;

        public frmStudentNovi(Student? student = null)
        {
            InitializeComponent();

            dgvStudentUloge.AutoGenerateColumns = false;

            _student = student ?? new Student();
        }

        private void frmStudentNovi_Load(object sender, EventArgs e)
        {
            UcitajSemestre();
            UcitajUloge();

            if (_student.Id == 0)
            {
                PostaviNaslov("Novi student");
            }
            else
            {
                PostaviNaslov("Uredi studenta");
                UcitajPodatkeOStudentu();
            };
        }

        private void PostaviNaslov(string naslov)
        {
            lblNaslov.Text = naslov;
        }

        private void UcitajPodatkeOStudentu()
        {
            txtIme.Text = _student.Ime;
            txtPrezime.Text = _student.Prezime;
            dtpDatumRodjenja.Value = _student.DatumRodjenja;
            txtKorisnickoIme.Text = _student.KorisnickoIme;
            txtEmail.Text = _student.Email;
            txtLozinka.Text = _student.Lozinka;
            txtBrojIndeksa.Text = _student.Indeks;
            cmbSemestar.SelectedValue = _student.SemestarId;
            pbSlika.Image = _student.Slika.ToImage();

            UcitajUlogeStudenta();
        }

        private void UcitajUlogeStudenta()
        {
            dgvStudentUloge.DataSource = null;
            dgvStudentUloge.DataSource = _student.Uloga.ToList();
        }

        private void UcitajUloge()
        {
            cmbUloge.PostaviComboBox(_dbContext.Uloge.ToList(), "Id", "Naziv");
        }

        private void UcitajSemestre()
        {
            cmbSemestar.PostaviComboBox(_dbContext.Semestri.ToList());
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnUlogaDodaj_Click(object sender, EventArgs e)
        {
            var izabranaUloga = cmbUloge.SelectedItem as Uloga;

            _student.Uloga.Add(izabranaUloga);

            UcitajUlogeStudenta();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos())
                return;

            _student.Ime = txtIme.Text;
            _student.Prezime = txtPrezime.Text;
            _student.DatumRodjenja = dtpDatumRodjenja.Value;
            _student.KorisnickoIme = txtKorisnickoIme.Text;
            _student.Email = txtEmail.Text;
            _student.Lozinka = txtLozinka.Text;
            _student.Indeks = txtBrojIndeksa.Text;
            _student.SemestarId = (int)cmbSemestar.SelectedValue;
            _student.Slika = pbSlika.Image.ToBytes();

            if (_student.Id == 0)
            {
                _dbContext.Studenti.Add(_student);
            }
            else
            {
                _dbContext.Entry(_student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

            _dbContext.SaveChanges();

            MessageBox.Show(Resursi.Get(Kljucevi.StudentKreiranUspjeh),
                Resursi.Get(Kljucevi.Info),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(txtIme, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost)) &&
                Validator.ProvjeriUnos(txtPrezime, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost)) &&
                Validator.ProvjeriUnos(dtpDatumRodjenja, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost)) &&
                Validator.ProvjeriUnos(txtKorisnickoIme, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost)) &&
                Validator.ProvjeriUnos(txtEmail, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost)) &&
                Validator.ProvjeriUnos(txtLozinka, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost)) &&
                Validator.ProvjeriUnos(txtBrojIndeksa, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost)) &&
                Validator.ProvjeriUnos(cmbSemestar, errorProvider, Resursi.Get(Kljucevi.ObaveznaVrijednost));
        }
    }
}