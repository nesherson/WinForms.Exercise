using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data.Ispit22._02._2024;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit22._02._2024
{
    public partial class frmProstorijeIB230003 : Form
    {
        private readonly DLWMSDbContext _dbContext;

        public frmProstorijeIB230003()
        {
            InitializeComponent();

            dgvProstorije.AutoGenerateColumns = false;

            _dbContext = new();
        }

        private async void frmProstorijeIB230003_Load(object sender, EventArgs e)
        {
            await UcitajProstorije();
        }

        private async Task UcitajProstorije()
        {
            var podaci = (await _dbContext.ProstorijeIB230003
                .Include(x => x.NastavaIB230003)
                .ToListAsync())
                .Select(GetDto)
                .ToList();
            dgvProstorije.DataSource = null;
            dgvProstorije.DataSource = podaci;
        }

        private ProstorijaPretragaIB230003 GetDto(ProstorijaIB230003 prostorija)
        {
            return new ProstorijaPretragaIB230003
            {
                Prostorija = prostorija,
                Naziv = prostorija.Naziv,
                Oznaka = prostorija.Oznaka,
                Kapacitet = prostorija.Kapacitet,
                Logo = prostorija.Logo?.ToImage(),
                BrojPredmeta = prostorija.NastavaIB230003.Count
            };
        }

        private async void btnNovaProstorija_Click(object sender, EventArgs e)
        {
            if (new frmNovaProstorijaIB230003().ShowDialog() == DialogResult.OK)
                await UcitajProstorije();
        }

        private async void dgvProstorije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaStavka = dgvProstorije.SelectedRows[0].DataBoundItem as ProstorijaPretragaIB230003;

            if (odabranaStavka == null)
                return;

            if (dgvProstorije.CurrentCell is DataGridViewButtonCell btnNastava && btnNastava.Value == "Nastava")
            {
                new frmNastavaIB230003(odabranaStavka.Prostorija).ShowDialog();
                return;
            }
            else if (dgvProstorije.CurrentCell is DataGridViewButtonCell btnPrisustvo && btnPrisustvo.Value == "Prisustvo")
            {
                new frmPrisustvaIB230003(odabranaStavka.Prostorija).ShowDialog();
                return;
            }

            if (new frmNovaProstorijaIB230003(odabranaStavka.Prostorija).ShowDialog() == DialogResult.OK)
                await UcitajProstorije();
        }

        private async void btnPrintaj_Click(object sender, EventArgs e)
        {
            var izabranaStavka = dgvProstorije.SelectedRows[0].DataBoundItem as ProstorijaPretragaIB230003;
            var prisustva = (await _dbContext.NastavaIB230003
                .Include(x => x.Predmet)
                .Include(x => x.PrisustvoIB230003)
                .ThenInclude(y => y.Student)
                .Where(x => x.ProstorijaId == izabranaStavka.Prostorija.Id)
                .ToListAsync())
                .SelectMany(x => x.PrisustvoIB230003)
                .ToList();

            var dto = new PrisustvoIzvjestajDTO
            {
                Prisustva = prisustva,
                NazivProstorije = izabranaStavka.Prostorija.Naziv
            };

            new frmIzvjestajIB230003(dto).ShowDialog();
        }
    }
}