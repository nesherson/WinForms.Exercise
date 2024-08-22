using Microsoft.EntityFrameworkCore;
using WinForms.Exercise.Data.IspitIB230123;
using WinForms.Exercise.Infrastructure;
using WinForms.Exercise.IspitIB230123.Izvjestaj;

namespace WinForms.Exercise.IspitIB230123
{
    public partial class frmUvjerenjaIB230123 : Form
    {
        private readonly DLWMSDbContext _dbContext = new();
        private int _studentId;
        private string _sadrzaj;
        public frmUvjerenjaIB230123(int studentId)
        {
            InitializeComponent();

            dgvUvjerenja.AutoGenerateColumns = false;

            _studentId = studentId;
        }

        private void frmUvjerenjaIB230123_Load(object sender, EventArgs e)
        {
            UcitajUvjerenja();
            SetBtnDodajZahjtevEnabled();
        }

        private void UcitajBrojUvjerenjaUZaglavlje(int brojUvjerenja)
        {
            Text = $"Broj uvjerenja -> {brojUvjerenja}";
        }

        private void UcitajUvjerenja()
        {
             var uvjerenja = _dbContext.StudentiUvjerenjaIB230123
                .Include(su => su.Student)
                .Where(x => x.StudentId == _studentId)
                .ToList();

            UcitajBrojUvjerenjaUZaglavlje(uvjerenja.Count);

            dgvUvjerenja.DataSource = null;
            dgvUvjerenja.DataSource = uvjerenja;
        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranoUvjerenje = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentUvjerenjeIB230123;

            if (odabranoUvjerenje == null)
                return;

            if (dgvUvjerenja.CurrentCell is DataGridViewButtonCell btnBrisi && btnBrisi.Value == "Brisi")
            {
                IzbrisiUvjerenje(odabranoUvjerenje);
            }
            else if (dgvUvjerenja.CurrentCell is DataGridViewButtonCell btnPrintaj && btnPrintaj.Value == "Printaj")
            {
                PrintajUvjerenje(odabranoUvjerenje);
            }
            else
            {

            }
        }

        private void PrintajUvjerenje(StudentUvjerenjeIB230123 odabranoUvjerenje)
        {
            var dto = new dtoStudentUvjerenjeIB230123()
            {
                UvjerenjeId = odabranoUvjerenje.Id,
                ImePrezime = $"{odabranoUvjerenje.Student.Ime} {odabranoUvjerenje.Student.Prezime}",
                BrojIndeksa = odabranoUvjerenje.Student.Indeks,
                Svrha = odabranoUvjerenje.SvrhaUvjerenja
            };

            var frmIzvjestajUvjerenje = new frmIzvjestajUvjerenjeIB230123(dto);
            if (frmIzvjestajUvjerenje.ShowDialog() == DialogResult.OK)
                UcitajUvjerenja();
        }

        private void IzbrisiUvjerenje(StudentUvjerenjeIB230123 odabranoUvjerenje)
        {
            var dialogResult = MessageBox.Show("Da li ste sigurni da zelite izbrisati izabrano uvjerenje", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No)
                return;

            _dbContext.StudentiUvjerenjaIB230123.Remove(odabranoUvjerenje);
            _dbContext.SaveChanges();

            UcitajUvjerenja();
        }

        private void btnUvjerenjeNovi_Click(object sender, EventArgs e)
        {
            var frmNovoUvjerenje = new frmNovoUvjerenjeIB230123(_studentId);
            if (frmNovoUvjerenje.ShowDialog() == DialogResult.OK)
                UcitajUvjerenja();

        }

        private void txtBrojZahtjeva_TextChanged(object sender, EventArgs e)
        {
            SetBtnDodajZahjtevEnabled();
        }

        private void SetBtnDodajZahjtevEnabled()
        {
            btnDodajZahtjev.Enabled = false;

            if (int.TryParse(txtBrojZahtjeva.Text, out int brojZahtjeva))
            {
                if (brojZahtjeva > 0)
                {
                    btnDodajZahtjev.Enabled = true;
                }
                else
                {
                    btnDodajZahtjev.Enabled = false;
                }
            }


        }

        private void btnDodajZahtjev_Click(object sender, EventArgs e)
        {
            var vrstaUvjerenja = cmbVrstaUvjerenja.Text;
            var svrhaUvjerenja = txtSvrhaIzdavanja.Text;
            var threadUvjerenja = new Thread(() => KreirajUvjerenja(vrstaUvjerenja, svrhaUvjerenja));
            threadUvjerenja.Start();
        }

        private void KreirajUvjerenja(string vrstaUvjerenja, string svrhaUvjerenja)
        {
            var brojZahtjeva = int.Parse(txtBrojZahtjeva.Text);
            var uvjerenje = _dbContext.StudentiUvjerenjaIB230123
                .Include(su => su.Student)
                .Where(x => x.StudentId == _studentId)
                .ToList()[0];


            for (int i = 0; i < brojZahtjeva; i++)
            {
                var vrijeme = DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss");
                var novoUvjerenje = new StudentUvjerenjeIB230123()
                {
                    VrstaUvjerenja = vrstaUvjerenja,
                    SvrhaUvjerenja = svrhaUvjerenja,
                    Uplatnica = uvjerenje.Uplatnica,
                    Printano = false,
                    VrijemeKreiranja = DateTime.Now,
                    StudentId = _studentId
                };

                _dbContext.StudentiUvjerenjaIB230123.Add(novoUvjerenje);
                _sadrzaj = $"{vrijeme} -> {novoUvjerenje.VrstaUvjerenja} ({uvjerenje.Student.Indeks}) - {uvjerenje.Student.Ime} {uvjerenje.Student.Prezime} u svrhu {novoUvjerenje.SvrhaUvjerenja}{Environment.NewLine}";
                BeginInvoke(PrikaziInfo);
                Thread.Sleep(300);
            }
            _dbContext.SaveChanges();
            _sadrzaj = "Dodavanje zavrseno!";
            BeginInvoke(PrikaziInfo);
            BeginInvoke(UcitajUvjerenja);
        }

        private void PrikaziInfo()
        {
            txtInfo.Text += _sadrzaj;
        }
    }
}
