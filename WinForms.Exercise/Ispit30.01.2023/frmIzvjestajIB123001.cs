using Microsoft.Reporting.WinForms;
using System.Net.Http.Headers;
using WinForms.Exercise.Data.Ispit30._01._2023;

namespace WinForms.Exercise.Ispit30._01._2023
{
	public partial class frmIzvjestajIB123001 : Form
	{
		private StudentUvjerenjeIB123001DTO _studentUvjerenjeDto;
		public frmIzvjestajIB123001(StudentUvjerenjeIB123001DTO studentUvjerenjeDto)
		{
			InitializeComponent();

			_studentUvjerenjeDto = studentUvjerenjeDto;
		}

		private void frmIzvjestajIB123001_Load(object sender, EventArgs e)
		{
			var rpc = new ReportParameterCollection
			{
				new ReportParameter("pImePrezime", _studentUvjerenjeDto.ImePrezime),
				new ReportParameter("pBrojIndeksa", _studentUvjerenjeDto.BrojIndeksa),
				new ReportParameter("pSvrha", _studentUvjerenjeDto.Svrha),
				new ReportParameter("pDatum", DateTime.Now.ToString())
			};

			reportViewer1.LocalReport.SetParameters(rpc);

			reportViewer1.RefreshReport();
		}
	}
}
