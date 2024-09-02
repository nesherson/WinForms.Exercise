using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit22._02._2024
{
    public partial class frmPocetnaIB230003 : Form
    {
        private readonly DLWMSDbContext _dbContext;

        public frmPocetnaIB230003()
        {
            InitializeComponent();

            _dbContext = new();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmProstorijeIB230003().ShowDialog();
        }

        private async void frmPocetnaIB230003_Load(object sender, EventArgs e)
        {
            await PrikaziBrojStudenata();
        }

        private async Task PrikaziBrojStudenata()
        {
            var brojStudenata = await _dbContext.StudentiIB230003.CountAsync();

            lblBrojStudenata.Text = $"Broj studenata u bazi -> {brojStudenata}";
        }
    }
}