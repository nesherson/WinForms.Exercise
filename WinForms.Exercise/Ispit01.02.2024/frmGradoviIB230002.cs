using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data.Ispit01._02._2024;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit01._02._2024
{
    public partial class frmGradoviIB230002 : Form
    {
        private readonly DLWMSDbContext _dbContext;

        private DrzavaIB230002 _drzava;
        private string _sadrzaj;

        public frmGradoviIB230002(DrzavaIB230002 drzava)
        {
            InitializeComponent();

            dgvGradovi.AutoGenerateColumns = false;
            _dbContext = new();

            _drzava = drzava;
        }

        private async void frmGradoviIB230002_Load(object sender, EventArgs e)
        {
            UcitajPodatkeODrzavi();
            await UcitajGradove();
        }

        private async Task UcitajGradove()
        {
            var podaci = await _dbContext.GradoviIB230002
                .Where(x => x.DrzavaId == _drzava.Id)
                .ToListAsync();

            dgvGradovi.DataSource = null;
            dgvGradovi.DataSource = podaci;
        }

        private void UcitajPodatkeODrzavi()
        {
            pbSlikaDrzave.Image = _drzava.Zastava?.ToImage();
            lblImeDrzave.Text = _drzava.Naziv;
        }

        private async void btnDodajGrad_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos())
                return;

            var noviGrad = new GradIB230002
            {
                Naziv = txtImeGrada.Text,
                Status = true,
                DrzavaId = _drzava.Id
            };

            await _dbContext.AddAsync(noviGrad);
            await _dbContext.SaveChangesAsync();
            await UcitajGradove();
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(txtImeGrada, err, Resursi.Get(Kljucevi.ObaveznaVrijednost));
        }

        private async void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniGrad = dgvGradovi.SelectedRows[0].DataBoundItem as GradIB230002;

            if (odabraniGrad == null)
                return;

            if (dgvGradovi.CurrentCell is DataGridViewButtonCell)
            {
                await PromijeniStatus(odabraniGrad);
                await UcitajGradove();
            }
        }

        private async Task PromijeniStatus(GradIB230002 odabraniGrad)
        {
            odabraniGrad.Status = !odabraniGrad.Status;

            _dbContext.Entry(odabraniGrad).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBrojGradova.Text, out int brojGradova))
                return;

            await Task.Run(() => GenerisiGradove(brojGradova, _drzava.Id, _drzava.Naziv, cbAktivniGradovi.Checked));
            await UcitajGradove();
        }

        private void GenerisiGradove(int brojGradova, int drzavaId, string imeDrzave, bool aktivniGradovi)
        {
            for (int i = 0; i < brojGradova; i++)
            {
                var noviGrad = new GradIB230002
                {
                    Naziv = $"Grad {i + 1}.",
                    Status = aktivniGradovi,
                    DrzavaId = drzavaId
                };

                _dbContext.Add(noviGrad);
                _sadrzaj = $"{DateTime.Now} -> dodat grad {noviGrad.Naziv} za drzavu {imeDrzave}\n";

                BeginInvoke(PrikaziSadrzaj);
            }

            _dbContext.SaveChanges();
        }

        private void PrikaziSadrzaj()
        {
            txtSadrzaj.Text += _sadrzaj;
        }
    }
}