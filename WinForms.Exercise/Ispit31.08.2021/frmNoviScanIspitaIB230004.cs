using WinForms.Exercise.Data.Ispit31._08._2021;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit31._08._2021
{
    public partial class frmNoviScanIspitaIB230004 : Form
    {
        private readonly DLWMSDbContext _dbContext;

        private StudentIspitScanEditDTO _editDto;

        public frmNoviScanIspitaIB230004(StudentIspitScanEditDTO editDto)
        {
            InitializeComponent();

            _dbContext = new();
            _editDto = editDto;
        }

        private void pbSlika_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmNoviScanIspitaIB230004_Load(object sender, EventArgs e)
        {
            UcitajPredmete();

            if (_editDto.StudentIspitScan != null)
            {
                UcitajPodatkeOIspitScan();
            }
        }

        private void UcitajPodatkeOIspitScan()
        {
            cmbPredmeti.Enabled = false;
            cmbPredmeti.SelectedValue = _editDto.StudentIspitScan.PredmetId;

            txtNapomena.Enabled = false;
            txtNapomena.Text = _editDto.StudentIspitScan.Napomena;
            cbVaranje.Enabled = false;
            cbVaranje.Checked = _editDto.StudentIspitScan.Varanje;

            pbSlika.Enabled = false;
            pbSlika.Image = _editDto.StudentIspitScan.SkeniranIspit?.ToImage();

            btnSpasi.Enabled = false;
        }

        private void UcitajPredmete()
        {
            var podaci = _dbContext.PredmetiIB230004.ToList();

            cmbPredmeti.PostaviComboBox(podaci, "Id", "Naziv");
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos())
                return;

            var noviIspitScan = new StudentIspitScanIB230004
            {
                PredmetId = (int)cmbPredmeti.SelectedValue,
                StudentId = _editDto.Student.Id,
                SkeniranIspit = pbSlika.Image.ToBytes(),
                Napomena = txtNapomena.Text,
                Varanje = cbVaranje.Checked
            };

            _dbContext.StudentiIspitiScanIB230004.Add(noviIspitScan);
            _dbContext.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(cmbPredmeti, errorProvider1, Resursi.Get(Kljucevi.ObaveznaVrijednost)) ||
                Validator.ProvjeriUnos(txtNapomena, errorProvider1, Resursi.Get(Kljucevi.ObaveznaVrijednost)) ||
                Validator.ProvjeriUnos(pbSlika, errorProvider1, Resursi.Get(Kljucevi.ObaveznaVrijednost));
        }
    }
}