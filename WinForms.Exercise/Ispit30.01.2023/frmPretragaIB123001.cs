using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data;
using WinForms.Exercise.Data.Ispit30._01._2023;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit30._01._2023
{
	public partial class frmPretragaIB123001 : Form
	{
		private readonly DLWMSDbContext _dbContext;
		public frmPretragaIB123001()
		{
			InitializeComponent();

			dgvStudenti.AutoGenerateColumns = false;

			_dbContext = new DLWMSDbContext();
		}

		private async void frmPretragaIB123001_Load(object sender, EventArgs e)
		{		
			dtpRodjenOd.Value = new DateTime(1990, 1, 1);
			dtpRodjenDo.Value = new DateTime(2000, 1, 1);

			await UcitajSpolove();
			await UcitajStudente();
		}

		private async Task UcitajSpolove()
		{
			var podaci = await _dbContext.SpoloviIB123001.ToListAsync();
			cmbSpolovi.PostaviComboBox(podaci);
		}

		private async Task UcitajStudente()
		{
			var spol = cmbSpolovi.SelectedItem as SpolIB123001;
			var datumOd = dtpRodjenOd.Value;
			var datumDo = dtpRodjenDo.Value;

			if (spol == null)
				return;

			dgvStudenti.DataSource = null;

			var podaci = (await _dbContext.StudentiIB123001
				.Include(x => x.PolozeniPredmetiIB123001)
				.Where(x => x.SpolId == spol.Id && x.DatumRodjenja >= datumOd && x.DatumRodjenja <= datumDo)
				.ToListAsync())
				.Select(GetDto)
				.ToList();

			if (podaci.Count == 0)
			{
				MessageBox.Show(
					$"U bazi podataka ne postoji evidencija o studentima {GetSpol(spol.Oznaka)} spola rođenih u periodu od {datumOd:dd.MM.yyyy} – {datumDo:dd.MM.yyyy}. godine.",
					"Informacija",
					MessageBoxButtons.OK);
				return;
			}


			dgvStudenti.DataSource = podaci;
		}

		private string GetSpol(string oznaka) => oznaka switch
		{
			"M" => "muškog",
			"Z" => "ženskog",
			_ => "nedefinisanog"
		};


		private StudentPretragaIB123001DTO GetDto(StudentIB123001 student)
		{
			var prosjek = (float)student.PolozeniPredmetiIB123001
				.Sum(x => x.Ocjena) / student.PolozeniPredmetiIB123001.Count;

			return new StudentPretragaIB123001DTO
			{
				StudentId = student.Id,
				ImePrezime = $"{student.Ime} {student.Prezime}",
				BrojIndeksa = student.Indeks,
				DatumRodjenja = student.DatumRodjenja,
				Aktivan = student.Aktivan,
				Prosjek = prosjek,
				Slika = student.Slika?.ToImage()
			};
		}

		private async void cmbSpolovi_SelectedIndexChanged(object sender, EventArgs e)
		{
			await UcitajStudente();
		}

		private async void dtpRodjenOd_ValueChanged(object sender, EventArgs e)
		{
			await UcitajStudente();
		}

		private async void dtpRodjenDo_ValueChanged(object sender, EventArgs e)
		{
			await UcitajStudente();
		}

		private async void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var studentDto = dgvStudenti.SelectedRows[0].DataBoundItem as StudentPretragaIB123001DTO;

			if (studentDto == null)
				return;

			if (dgvStudenti.CurrentCell is DataGridViewButtonCell)
			{
				var student = await _dbContext.StudentiIB123001
					.FirstOrDefaultAsync(x => x.Id == studentDto.StudentId);

				new frmUvjerenjaIB123001(student).Show();
				await UcitajStudente();
				return;
			}

			new frmStudentInfoIB123001(studentDto).Show();
		}
	}
}
