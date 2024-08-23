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
			var brojStudenata = await _dbContext.StudentiIB123002.CountAsync();

			lblBrojStudenata.Text = $"Broj studenata u bazi -> {brojStudenata}";
		}
	}
}
