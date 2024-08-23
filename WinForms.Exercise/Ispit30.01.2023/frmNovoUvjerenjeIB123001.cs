using WinForms.Exercise.Data;
using WinForms.Exercise.Data.Ispit30._01._2023;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit30._01._2023
{
	public partial class frmNovoUvjerenjeIB123001 : Form
	{
		private readonly DLWMSDbContext _dbContext;
		private Student _student;
		public frmNovoUvjerenjeIB123001(Student student)
		{
			InitializeComponent();

			_dbContext = new();

			_student = student;
		}

		private void pbUplatnica_DoubleClick(object sender, EventArgs e)
		{
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				pbUplatnica.Image = Image.FromFile(fileDialog.FileName);
			}
		}

		private async void btnSacuvaj_Click(object sender, EventArgs e)
		{
			if (!ValidanUnos())
				return;

			var novoUvjerenje = new StudentUvjerenjeIB123001
			{
				SvrhaUvjerenja = txtSvrhaIzdavanja.Text,
				VrijemeKreiranja = DateTime.Now,
				VrstaUvjerenja = cmbVrstaUvjerenja.Text,
				Uplatnica = pbUplatnica.Image.ToBytes(),
				StudentId = _student.Id
			};

			await _dbContext.StudentiUvjerenjaIB123001.AddAsync(novoUvjerenje);
			await _dbContext.SaveChangesAsync();

			DialogResult = DialogResult.OK;
			Close();
		}

		private bool ValidanUnos()
		{
			return Validator.ProvjeriUnos(txtSvrhaIzdavanja, err, Resursi.Get(Kljucevi.ObaveznaVrijednost)) &&
				Validator.ProvjeriUnos(pbUplatnica, err, Resursi.Get(Kljucevi.ObaveznaVrijednost));
		}

		private void frmNovoUvjerenjeIB123001_Load(object sender, EventArgs e)
		{
			cmbVrstaUvjerenja.SelectedIndex = 0;
		}
	}
}
