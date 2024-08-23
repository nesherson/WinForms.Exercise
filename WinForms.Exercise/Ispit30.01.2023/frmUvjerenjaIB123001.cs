using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data;
using WinForms.Exercise.Data.Ispit30._01._2023;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit30._01._2023
{
	public partial class frmUvjerenjaIB123001 : Form
	{
		private readonly DLWMSDbContext _dbContext;
		private Student _student;
		public frmUvjerenjaIB123001(Student student)
		{
			InitializeComponent();

			dgvUvjerenja.AutoGenerateColumns = false;

			_dbContext = new();
			_student = student;
		}

		private async void frmUvjerenjaIB123001_Load(object sender, EventArgs e)
		{
			await UcitajUvjerenja();
		}

		private async Task UcitajUvjerenja()
		{
			var podaci = await _dbContext.StudentiUvjerenjaIB123001
				.Where(x => x.StudentId == _student.Id)
				.ToListAsync();
			dgvUvjerenja.DataSource = null;
			dgvUvjerenja.DataSource = podaci;
			Text = $"Broj uvjerenja -> {podaci.Count}";
		}

		private async void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var odabranoUvjerenje = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentUvjerenjeIB123001;

			if (odabranoUvjerenje == null)
				return;

			if (dgvUvjerenja.CurrentCell is DataGridViewButtonCell btnCell)
			{
				if (btnCell.Value == "Briši")
				{
					await IzbrisiUvjerenje(odabranoUvjerenje);
				}
				else if (btnCell.Value == "Printaj")
				{
					await OtvoriFormuZaPrintanje(odabranoUvjerenje);	
				}
			}
		}

		private async Task OtvoriFormuZaPrintanje(StudentUvjerenjeIB123001 studentUvjerenje)
		{
			studentUvjerenje.Printano = true;
			_dbContext.Entry(studentUvjerenje).State = EntityState.Modified;
			await _dbContext.SaveChangesAsync();

			var studentUvjerenjeDto = new StudentUvjerenjeIB123001DTO
			{
				ImePrezime = $"{_student.Ime} {_student.Prezime}",
				BrojIndeksa = _student.Indeks,
				Svrha = studentUvjerenje.SvrhaUvjerenja
			};

			new frmIzvjestajIB123001(studentUvjerenjeDto).Show();

			await UcitajUvjerenja();
		}


		private async Task IzbrisiUvjerenje(StudentUvjerenjeIB123001 odabranoUvjerenje)
		{
			if (MessageBox.Show("Potvrda brisanja", "Da li ste sigurni da želite obrisati uvjerenje?", MessageBoxButtons.YesNo) != DialogResult.Yes)
				return;

			_dbContext.StudentiUvjerenjaIB123001.Remove(odabranoUvjerenje);
			await _dbContext.SaveChangesAsync();

			await UcitajUvjerenja();
		}

		private async void btnNoviZahtjev_Click(object sender, EventArgs e)
		{
			if (new frmNovoUvjerenjeIB123001(_student).ShowDialog() == DialogResult.OK)
				await UcitajUvjerenja();
		}
	}
}
