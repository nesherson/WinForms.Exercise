using Microsoft.Reporting.WinForms;
using WinForms.Exercise.Data.Ispit22._02._2024;

namespace WinForms.Exercise.Ispit22._02._2024
{
    public partial class frmIzvjestajIB230003 : Form
    {
        private PrisustvoIzvjestajDTO _dto;

        public frmIzvjestajIB230003(PrisustvoIzvjestajDTO dto)
        {
            InitializeComponent();

            _dto = dto;
        }

        private void frmIzvjestajIB230003_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection
            {
                new ReportParameter("pNazivProstorije", _dto.NazivProstorije)
            };

            var dataTable = new dsNastava.NastavaDataTable();

            for (int i = 0; i < _dto.Prisustva.Count; i++)
            {
                var prisustvo = _dto.Prisustva[i];

                dataTable.AddNastavaRow(
                    (i + 1).ToString(),
                    prisustvo.Nastava.Predmet.ToString(),
                    prisustvo.Nastava.Vrijeme,
                    prisustvo.Student.Indeks,
                    $"{prisustvo.Student.Ime} {prisustvo.Student.Prezime}");
            };

            var dataSource = new ReportDataSource
            {
                Value = dataTable,
                Name = "DataSet1"
            };

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportViewer1.RefreshReport();
        }
    }
}