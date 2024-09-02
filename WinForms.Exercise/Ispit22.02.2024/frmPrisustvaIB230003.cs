using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data.Ispit01._02._2024;
using WinForms.Exercise.Data.Ispit22._02._2024;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit22._02._2024
{
    public partial class frmPrisustvaIB230003 : Form
    {
        private readonly DLWMSDbContext _dbContext;

        private ProstorijaIB230003 _prostorija;
        private string _sadrzaj;

        public frmPrisustvaIB230003(ProstorijaIB230003 prostorija)
        {
            InitializeComponent();

            dgvPrisustva.AutoGenerateColumns = false;

            _dbContext = new();
            _prostorija = prostorija;
        }

        private async void frmPrisustvaIB230003_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOProstoriji();
            await UcitajNastavu();
            await UcitajStudente();
            await UcitajPrisustva();
        }

        private void UcitajPodatkeOProstoriji()
        {
            lblImeProstorije.Text = $"{_prostorija.Oznaka} - {_prostorija.Naziv}";
        }

        private async Task UcitajPrisustva()
        {
            var podaci = (await _dbContext.NastavaIB230003
                .Include(n => n.PrisustvoIB230003)
                .Where(x => x.ProstorijaId == _prostorija.Id)
                .ToListAsync())
                .SelectMany(x => x.PrisustvoIB230003)
                .ToList();

            dgvPrisustva.DataSource = null;
            dgvPrisustva.DataSource = podaci;

            lblBrojPrisustva.Text = $"{podaci.Count}/{_prostorija.Kapacitet}";
        }

        private async Task UcitajStudente()
        {
            var podaci = await _dbContext.StudentiIB230003
                .ToListAsync();

            cmbStudent.PostaviComboBox(podaci, "Id", "Oznaka");
        }

        private async Task UcitajNastavu()
        {
            var podaci = await _dbContext.NastavaIB230003
                .Where(x => x.ProstorijaId == _prostorija.Id)
                .ToListAsync();

            cmbNastava.PostaviComboBox(podaci);
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos())
                return;

            var novoPrisustvo = new PrisustvoIB230003
            {
                StudentId = (int)cmbStudent.SelectedValue,
                NastavaId = (int)cmbNastava.SelectedValue
            };

            await _dbContext.PrisustvaIB230003.AddAsync(novoPrisustvo);
            await _dbContext.SaveChangesAsync();
            await UcitajPrisustva();
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(cmbNastava, errorProvider1, Resursi.Get(Kljucevi.ObaveznaVrijednost)) ||
                Validator.ProvjeriUnos(cmbStudent, errorProvider1, Resursi.Get(Kljucevi.ObaveznaVrijednost));
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            var nastave = await _dbContext.NastavaIB230003
                .Where(x => x.ProstorijaId == _prostorija.Id)
                .ToListAsync();
            var student = cmbStudent.SelectedItem as StudentIB230003;
            int brojZapisa = 0;
            var brojPrisustva = (dgvPrisustva.DataSource as List<PrisustvoIB230003>).Count;

            if (!int.TryParse(txtBrojZapisa.Text, out brojZapisa))
                return;

            if (brojZapisa > _prostorija.Kapacitet - brojPrisustva)
            {
                MessageBox.Show("Premasili ste kapacitet prostorije!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await Task.Run(() => GenerisiPodatke(nastave, student, brojZapisa));
        }

        private void GenerisiPodatke(List<NastavaIB230003> nastave, StudentIB230003 student, int brojZapisa)
        {
            for (int i = 0; i < nastave.Count; i++)
            {
                for (int j = 0; j < brojZapisa; j++)
                {
                    var novoPrisustvo = new PrisustvoIB230003
                    {
                        NastavaId = nastave[i].Id,
                        StudentId = student.Id,
                    };

                    _dbContext.PrisustvaIB230003.Add(novoPrisustvo);
                    Thread.Sleep(300);
                    _sadrzaj = $"{DateTime.Now} -> {student} za {nastave[i].Oznaka}";

                    BeginInvoke(PrikaziSadrzaj);
                }
            }

            _dbContext.SaveChanges();
            UcitajPrisustva();
        }

        private void PrikaziSadrzaj()
        {
            txtSadrzaj.Text += _sadrzaj;
        }
    }
}