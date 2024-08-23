using WinForms.Exercise.Data.Ispit30._01._2023;

namespace WinForms.Exercise.Ispit30._01._2023
{
	public partial class frmStudentInfoIB123001 : Form
	{
		private StudentPretragaIB123001DTO _studentDto;
		public frmStudentInfoIB123001(StudentPretragaIB123001DTO studentDto)
		{
			InitializeComponent();

			_studentDto = studentDto;
		}

		private void frmStudentInfoIB123001_Load(object sender, EventArgs e)
		{
			UcitajPodatkeOStudentu();
		}

		private void UcitajPodatkeOStudentu()
		{
			Text = _studentDto.BrojIndeksa;
			pbSlikaStudenta.Image = _studentDto.Slika;
			lblImePrezime.Text = _studentDto.ImePrezime;
			lblProsjekVrijednost.Text = _studentDto.Prosjek.ToString();
		}
	}
}
