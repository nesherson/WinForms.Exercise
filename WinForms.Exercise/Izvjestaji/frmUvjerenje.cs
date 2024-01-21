using Microsoft.Reporting.WinForms;
using WinForms.Exercise.Data.DTO;

namespace WinForms.Exercise.Izvjestaji
{
    public partial class frmUvjerenje : Form
    {
        private dtoStudentUvjerenje _dtoStudentUvjerenje;
        public frmUvjerenje(dtoStudentUvjerenje dtoStudentUvjerenje)
        {
            InitializeComponent();

            _dtoStudentUvjerenje = dtoStudentUvjerenje;
        }

        private void frmUvjerenje_Load(object sender, EventArgs e)
        {

            var polozeniPredmeti = _dtoStudentUvjerenje.PolozeniPredmeti;

            var rpc = new ReportParameterCollection
            {
                new ReportParameter("pImePrezime", _dtoStudentUvjerenje.ImePrezime),
                new ReportParameter("pBrojIndeksa", _dtoStudentUvjerenje.BrojIndeksa),
                new ReportParameter("pStatus", _dtoStudentUvjerenje.Status),
                new ReportParameter("pSvrha", _dtoStudentUvjerenje.Svrha),
                new ReportParameter("pAkademskaGodina", _dtoStudentUvjerenje.AkademskaGodina)
            };

            var dataTable = new dsDLWMS.PolozeniIspitiDataTable();

            for (int i = 0; i < polozeniPredmeti.Count; i++)
            {
                var red = dataTable.NewPolozeniIspitiRow();
                red.Rb = (i + 1).ToString();
                red.Predmet = polozeniPredmeti[i].Predmet.Naziv;
                red.Ocjena = polozeniPredmeti[i].Ocjena.ToString();
                red.DatumPolaganja = polozeniPredmeti[i].DatumPolaganja.ToString("dd.MM.yyyy");

                dataTable.AddPolozeniIspitiRow(red);
            }

            var reportDataSource = new ReportDataSource
            {
                Name = "PolozeniIspiti",
                Value = dataTable
            };

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
        }
    }
}
