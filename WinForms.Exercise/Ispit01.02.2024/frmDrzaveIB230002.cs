using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data.Ispit01._02._2024;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit01._02._2024
{
    public partial class frmDrzaveIB230002 : Form
    {
        private readonly DLWMSDbContext _dbContext;

        public frmDrzaveIB230002()
        {
            InitializeComponent();

            dgvDrzave.AutoGenerateColumns = false;
            timer.Interval = 1000;

            _dbContext = new();

            timer.Start();
        }

        private async void frmDrzaveIB230002_Load(object sender, EventArgs e)
        {
            UcitajVrijeme();
            await UcitajDrzave();
        }

        private async Task UcitajDrzave()
        {
            var podaci = (await _dbContext.DrzaveIB230002
                .Include(x => x.GradIB230002)
                .ToListAsync())
                .Select(GetDto)
                .ToList();

            dgvDrzave.DataSource = null;
            dgvDrzave.DataSource = podaci;
        }

        private void UcitajVrijeme()
        {
            tslVrijeme.Text = DateTime.Now.ToString();
        }

        private DrzavaPretragaIB230002DTO GetDto(DrzavaIB230002 drzava)
        {
            return new DrzavaPretragaIB230002DTO
            {
                Drzava = drzava.Naziv,
                Zastava = drzava.Zastava,
                BrojGradova = drzava.GradIB230002.Count,
                Aktivna = drzava.Status,
                _Drzava = drzava
            };
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UcitajVrijeme();
        }

        private async void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            var forma = new frmNovaDrzavaIB230002();

            if (forma.ShowDialog() == DialogResult.OK)
                await UcitajDrzave();
        }

        private async void dgvDrzave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaDrzava = (dgvDrzave.SelectedRows[0].DataBoundItem as DrzavaPretragaIB230002DTO)?
              ._Drzava;

            if (odabranaDrzava == null)
                return;

            Form forma = null;

            if (dgvDrzave.CurrentCell is DataGridViewButtonCell)
            {
                forma = new frmGradoviIB230002(odabranaDrzava);

                forma.ShowDialog();
                await UcitajDrzave();
            }
            else
            {
                forma = new frmNovaDrzavaIB230002(odabranaDrzava);

                if (forma.ShowDialog() == DialogResult.OK)
                    await UcitajDrzave();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var odabranaDrzava = dgvDrzave.SelectedRows[0].DataBoundItem as DrzavaPretragaIB230002DTO;

            if (odabranaDrzava == null)
                return;

            var dto = new GradoviReportDTO
            {
                Drzava = odabranaDrzava._Drzava.Naziv,
                Gradovi = odabranaDrzava._Drzava.GradIB230002
            };

            new frmIzvjestajIB230002(dto).ShowDialog();
        }
    }
}