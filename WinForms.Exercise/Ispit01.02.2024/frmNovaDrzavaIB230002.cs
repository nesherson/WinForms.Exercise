using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data.Ispit01._02._2024;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit01._02._2024
{
    public partial class frmNovaDrzavaIB230002 : Form
    {
        private readonly DLWMSDbContext _dbContext;
        private DrzavaIB230002 _drzava;

        public frmNovaDrzavaIB230002(DrzavaIB230002? drzava = null)
        {
            InitializeComponent();

            _dbContext = new();
            _drzava = drzava ?? new DrzavaIB230002();
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            _drzava.Naziv = txtNaziv.Text;
            _drzava.Status = cbAktivna.Checked;
            _drzava.Zastava = pbZastava.Image.ToBytes();

            if (_drzava.Id == 0)
            {
                await _dbContext.DrzaveIB230002.AddAsync(_drzava);
            }
            else
            {
                _dbContext.Entry(_drzava).State = EntityState.Modified;
            }

            await _dbContext.SaveChangesAsync();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmNovaDrzavaIB230002_Load(object sender, EventArgs e)
        {
            if (_drzava.Id != 0)
            {
                UcitajPodatkeOPostojecojDrzavi();
            }
        }

        private void UcitajPodatkeOPostojecojDrzavi()
        {
            txtNaziv.Text = _drzava.Naziv;
            cbAktivna.Checked = _drzava.Status;
            pbZastava.Image = _drzava.Zastava?.ToImage();
        }

        private void pbZastava_DoubleClick(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(fileDialog.FileName);
            }
        }
    }
}