using Microsoft.Reporting.WinForms;
using WinForms.Exercise.Data.Ispit01._02._2024;

namespace WinForms.Exercise.Ispit01._02._2024
{
    public partial class frmIzvjestajIB230002 : Form
    {
        private GradoviReportDTO _dto;

        public frmIzvjestajIB230002(GradoviReportDTO dto)
        {
            InitializeComponent();

            _dto = dto;
        }

        private void frmIzvjestajIB230002_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection()
            {
                new ReportParameter("pBrojGradova", _dto.Gradovi.Count.ToString())
            };

            var dataTable = new dsGradovi.GradDataTable();

            for (int i = 0; i < _dto.Gradovi.Count; i++)
            {
                dataTable.AddGradRow(_dto.Gradovi[i].Naziv,
                   _dto.Drzava,
                    _dto.Gradovi[i].Status ? "DA" : "NE",
                    (i + 1).ToString());
            }

            var rds = new ReportDataSource();
            rds.Value = dataTable;
            rds.Name = "dsGradovi";

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}