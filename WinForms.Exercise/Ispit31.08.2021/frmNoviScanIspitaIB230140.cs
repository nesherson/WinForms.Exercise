using WinForms.Exercise.Data.Ispit31._08._2021;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit31._08._2021
{
    public partial class frmNoviScanIspitaIB230140 : Form
    {
        private readonly DLWMSDbContext _dbContext = new();

        private int _studentId;
        public frmNoviScanIspitaIB230140(int studentId)
        {
            InitializeComponent();

            _studentId = studentId;
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos())
                return;

            var noviScanIspita = new StudentIspitScanIB230124()
            {
                StudentId = _studentId,
                PredmetId = (int)cmbPredmet.SelectedValue,
                Napomena = txtNapomena.Text,
                SkeniranIspit = pbSlika.Image.ToBytes(),
                Varanje = cbVaranje.Checked
            };

            _dbContext.StudentiIspitiScanIB230124.Add(noviScanIspita);
            _dbContext.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(cmbPredmet, errorProvider, "Obavezna vrijednost") &&
                Validator.ProvjeriUnos(txtNapomena, errorProvider, "Obavezna vrijednost") &&
                Validator.ProvjeriUnos(pbSlika, errorProvider, "Obavezna vrijednost");
        }

        private void frmNoviScanIspitaIB230140_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            cmbPredmet.PostaviComboBox(_dbContext.Predmeti.ToList());
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
