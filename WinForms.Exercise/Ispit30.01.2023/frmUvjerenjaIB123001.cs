using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data;
using WinForms.Exercise.Data.Ispit30._01._2023;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit30._01._2023
{
	public partial class frmUvjerenjaIB123001 : Form
	{
		private readonly DLWMSDbContext _dbContext;
		private StudentIB123001 _student;
		private string _sadrzaj;
		public frmUvjerenjaIB123001(StudentIB123001 student)
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
			var brojPodataka = podaci.Count;

			dgvUvjerenja.DataSource = null;
			dgvUvjerenja.DataSource = podaci;

			Text = $"Broj uvjerenja -> {brojPodataka}";
			btnDodaj.Enabled = brojPodataka > 0;
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
			if (MessageBox.Show(Resursi.Get(Kljucevi.UvjerenjePotvrdaBrisanja), Resursi.Get(Kljucevi.Upozorenje), MessageBoxButtons.YesNo) != DialogResult.Yes)
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

		private async void btnDodaj_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtBrojZahtjeva.Text, out int brojZahtjeva))
			{
				MessageBox.Show(Resursi.Get(Kljucevi.BrojZahtjevaValidnaVrijednost), Resursi.Get(Kljucevi.Info), MessageBoxButtons.OK);
				return;
			}

			var studentUvjerenjeDto = new StudentUvjerenjeThreadIB123001DTO
			{
				ImePrezime = $"{_student.Ime} {_student.Prezime}",
				Vrsta = cmbVrstaUvjerenja.Text,
				Svrha = txtSvrhaIzdavanja.Text,
				BrojZahtjeva = brojZahtjeva,
				Uplatnica = (dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentUvjerenjeIB123001).Uplatnica,
				StudentId = _student.Id
			};

			await Task.Run(() => DodajUvjerenje(studentUvjerenjeDto));
			await UcitajUvjerenja();
		}

		private void PrikaziSadrzaj()
		{
			txtSadrzaj.Text += _sadrzaj;
		}

		private void DodajUvjerenje(StudentUvjerenjeThreadIB123001DTO dto)
		{
			for (int i = 0; i < dto.BrojZahtjeva; i++)
			{
				var novoUvjerenje = new StudentUvjerenjeIB123001
				{
					VrijemeKreiranja = DateTime.Now,
					VrstaUvjerenja = dto.Vrsta,
					SvrhaUvjerenja = dto.Svrha,
					Uplatnica = dto.Uplatnica,
					StudentId = dto.StudentId
				};

				_dbContext.StudentiUvjerenjaIB123001.Add(novoUvjerenje);
			
				_sadrzaj = $"{novoUvjerenje.VrijemeKreiranja.TimeOfDay} -> Uvjerenje o statusu studenta ({dto.BrojIndeksa}) - {dto.ImePrezime} u svrhu {dto.Svrha}{Environment.NewLine}";

				BeginInvoke(PrikaziSadrzaj);
				Thread.Sleep(300);
			}

			_dbContext.SaveChanges();
		}
	}
}
