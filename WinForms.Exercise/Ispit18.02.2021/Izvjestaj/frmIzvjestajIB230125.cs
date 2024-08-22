using Microsoft.Reporting.WinForms;
using WinForms.Exercise.Data.Ispit18._02._2021;

namespace WinForms.Exercise.Ispit18._02._2021.Izvjestaj
{
    public partial class frmIzvjestajIB230125 : Form
    {
        private List<dtoStudentCovidTest> _dtoLista;
        public frmIzvjestajIB230125(List<dtoStudentCovidTest> dtoLista)
        {
            InitializeComponent();
            _dtoLista = dtoLista;
        }

        private void frmIzvjestajIB230125_Load(object sender, EventArgs e)
        {
            var dataSet = new Covid.StudentCovidTestDataTable();

            foreach (var test in _dtoLista)
            {
                var red = dataSet.NewStudentCovidTestRow();
                red.Student = test.Student;
                red.Datum = test.Datum;
                red.Rezultat = test.Rezultat;
                red.NalazDostavljen = test.NalazDostavljen;

                dataSet.AddStudentCovidTestRow(red);
            }

            var dataSource = new ReportDataSource();
            dataSource.Name = "StudentCovidTest"; ;
            dataSource.Value = dataSet;

            reportViewer.LocalReport.DataSources.Add(dataSource);
            reportViewer.RefreshReport();
        }
    }
}
