using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data.Ispit31._08._2021;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit31._08._2021
{
    public partial class frmScanIspitaIB230004 : Form
    {
        private readonly DLWMSDbContext _dbContext;

        private StudentIB230004 _student;

        public frmScanIspitaIB230004(StudentIB230004 student)
        {
            InitializeComponent();

            dgvIspitiScan.AutoGenerateColumns = false;

            _dbContext = new();
            _student = student;
        }

        private void frmScanIspitaIB230004_Load(object sender, EventArgs e)
        {
            UcitajScanIspita();
        }

        private void UcitajScanIspita()
        {
            var podaci = _dbContext.StudentiIspitiScanIB230004
                .Include(sic => sic.Predmet)
                .Include(sic => sic.Student)
                .Where(x => x.StudentId == _student.Id)
                .ToList();

            dgvIspitiScan.DataSource = null;
            dgvIspitiScan.DataSource = podaci;
        }

        private void dgvIspitiScan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaStavka = dgvIspitiScan.SelectedRows[0].DataBoundItem as StudentIspitScanIB230004;

            if (odabranaStavka == null)
                return;

            if (dgvIspitiScan.CurrentCell is DataGridViewButtonCell btn && btn.Value == "Briši")
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _dbContext.Remove(odabranaStavka);
                    _dbContext.SaveChanges();
                    UcitajScanIspita();
                    return;
                }
            }
        }

        private void btnDodajScan_Click(object sender, EventArgs e)
        {
            var dto = new StudentIspitScanEditDTO
            {
                Student = _student
            };

            if (new frmNoviScanIspitaIB230004(dto).ShowDialog() == DialogResult.OK)
                UcitajScanIspita();
        }

        private void dgvIspitiScan_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaStavka = dgvIspitiScan.SelectedRows[0].DataBoundItem as StudentIspitScanIB230004; ;

            if (odabranaStavka == null)
                return;

            var dto = new StudentIspitScanEditDTO
            {
                Student = _student,
                StudentIspitScan = odabranaStavka
            };

            if (new frmNoviScanIspitaIB230004(dto).ShowDialog() == DialogResult.OK)
                UcitajScanIspita();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var podaci = dgvIspitiScan.DataSource as List<StudentIspitScanIB230004>;

            if (podaci.Count == 0)
                return;

            new frmIzvjestajIB230004(podaci).ShowDialog();
        }
    }
}