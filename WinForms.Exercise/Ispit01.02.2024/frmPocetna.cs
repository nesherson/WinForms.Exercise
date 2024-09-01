using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit01._02._2024
{
    public partial class frmPocetna : Form
    {
        private readonly DLWMSDbContext _dbContext;

        public frmPocetna()
        {
            InitializeComponent();

            _dbContext = new();
        }

        private async void frmPocetna_Load(object sender, EventArgs e)
        {
            await UcitajBrojStudenata();
        }

        private async Task UcitajBrojStudenata()
        {
            var brojStudenata = await _dbContext.StudentiIB230002.CountAsync();

            lblBrojStudenata.Text = $"Broj studenata u bazi -> {brojStudenata}";
        }

        private void btnDrzaveGradovi_Click(object sender, EventArgs e)
        {
            var forma = new frmDrzaveIB230002();

            Hide();

            forma.Show();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            var forma = new frmPretragaIB230002();

            Hide();

            forma.Show();
        }
    }
}