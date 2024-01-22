using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using WinForms.Exercise.Data.IspitIB230123;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.IspitIB230123.Izvjestaj
{
    public partial class frmIzvjestajUvjerenjeIB230123 : Form
    {
        private readonly DLWMSDbContext _dbContext = new();

        private dtoStudentUvjerenjeIB230123 _dtoStudentUvjerenje;
        public frmIzvjestajUvjerenjeIB230123(dtoStudentUvjerenjeIB230123 dtoStudentUvjerenje)
        {
            InitializeComponent();

            _dtoStudentUvjerenje = dtoStudentUvjerenje;
        }

        private void frmIzvjestajUvjerenjeIB230123_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection()
            {
                new ReportParameter("pImePrezime", _dtoStudentUvjerenje.ImePrezime),
                new ReportParameter("pBrojIndeksa", _dtoStudentUvjerenje.BrojIndeksa),
                new ReportParameter("pSvrha", _dtoStudentUvjerenje.Svrha)
            };

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();

            AzurirajUvjerenje();
        }

        private void AzurirajUvjerenje()
        {
            var uvjerenje = _dbContext.StudentiUvjerenjaIB230123
                .FirstOrDefault(x => x.Id == _dtoStudentUvjerenje.UvjerenjeId);

            uvjerenje.Printano = true;

            _dbContext.Entry(uvjerenje).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
