using Microsoft.Reporting.WinForms;
using WinForms.Exercise.Data.Ispit31._08._2021;

namespace WinForms.Exercise.Ispit31._08._2021
{
    public partial class frmIzvjestajIB230004 : Form
    {
        private List<StudentIspitScanIB230004> _studentIspitScanList;

        public frmIzvjestajIB230004(List<StudentIspitScanIB230004> studentIspitScanList)
        {
            InitializeComponent();

            _studentIspitScanList = studentIspitScanList;
        }

        private void frmIzvjestajIB230004_Load(object sender, EventArgs e)
        {
            var dataTable = new dsSkeniraniIspiti.SkeniraniIspitDataTable();

            for (int i = 0; i < _studentIspitScanList.Count; i++)
            {
                var studentIspitScan = _studentIspitScanList[i];

                dataTable.AddSkeniraniIspitRow(
                    (i + 1).ToString(),
                    studentIspitScan.Predmet.Naziv,
                    $"{studentIspitScan.Student.Ime} {studentIspitScan.Student.Prezime}",
                    studentIspitScan.Varanje ? "DA" : "NE"
                    );
            }

            var dataSource = new ReportDataSource()
            {
                Name = "dsSkeniraniIspiti",
                Value = dataTable
            };

            reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportViewer1.RefreshReport();
        }
    }
}