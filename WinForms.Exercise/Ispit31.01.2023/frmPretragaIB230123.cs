using WinForms.Exercise.Data.IspitIB230123;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.IspitIB230123
{
    public partial class frmPretragaIB230123 : Form
    {
        private readonly DLWMSDbContext _dbContext = new();

        private bool cmbSpolInicijalniLoad = true;
        public frmPretragaIB230123()
        {
            InitializeComponent();

            dgvStudentiPretraga.AutoGenerateColumns = false;
        }

        private void frmPretragaIB230123_Load(object sender, EventArgs e)
        {
            UcitajSpolove();
            UcitajStudente();
        }

        private void UcitajSpolove()
        {
            cmbSpol.PostaviComboBox(_dbContext.Spolovi.ToList());
        }

        private void UcitajStudente(List<dtoStudentPretragaIB230123>? studenti = null)
        {
            dgvStudentiPretraga.DataSource = null;
            dgvStudentiPretraga.DataSource = studenti ?? _dbContext
                .StudentiIB230123
                .Select(ModelToDto)
                .ToList(); ;
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbSpolInicijalniLoad)
                PretraziStudente();
            else
                cmbSpolInicijalniLoad = false;
        }

        private void PretraziStudente()
        {
            var spolId = (int)cmbSpol.SelectedValue;
            var rodjenOd = dtpRodjenOd.Value;
            var rodjenDo = dtpRodjenDo.Value;
            var rezultat = _dbContext.StudentiIB230123
                .Where(x => x.SpolId == spolId && x.DatumRodjenja >= rodjenOd && x.DatumRodjenja <= rodjenDo)
                .Select(ModelToDto)
                .ToList();

            UcitajStudente(rezultat);

            if (rezultat.Count == 0)
            {
                MessageBox.Show($"U bazi podataka ne postoji evidencija o studentima {GetSpolText(spolId)} spola rodjenih u periodu od {rodjenOd.ToString("dd.MM.yyyy")} do {rodjenDo.ToString("dd.MM.yyyy")}");
            }
        }

        private dtoStudentPretragaIB230123 ModelToDto(StudentIB230123 student)
        {
            var polozeniPredmeti = _dbContext.PolozeniPredmetiIB230123
                .Where(x => x.StudentId == student.Id)
                .ToList();

            decimal sumaOcjena = 0;
            decimal prosjek = 0;
            foreach (var polozeniPredmet in polozeniPredmeti)
            {
                sumaOcjena += polozeniPredmet.Ocjena;
            }

            if (sumaOcjena > 0)
                prosjek = sumaOcjena / polozeniPredmeti.Count;



            return new dtoStudentPretragaIB230123()
            {
                StudentId = student.Id,
                ImePrezime = $"{student.Ime} {student.Prezime}",
                BrojIndeksa = student.Indeks,
                Prosjek = prosjek,
                DatumRodjenja = student.DatumRodjenja,
                Aktivan = student.Aktivan,
                Slika = student.Slika.ToImage()
            };
        }

        private void dtpRodjenOd_ValueChanged(object sender, EventArgs e)
        {
            PretraziStudente();
        }

        private void dtpRodjenDo_ValueChanged(object sender, EventArgs e)
        {
            PretraziStudente();
        }

        private string GetSpolText(int spolId)
        {
            var spol = _dbContext.Spolovi
                .FirstOrDefault(x => x.Id == spolId);

            return spol.Oznaka == "M" ? "muskog" : "zenskog";
        }

        private void dgvStudentiPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dto = dgvStudentiPretraga.SelectedRows[0].DataBoundItem as dtoStudentPretragaIB230123;

            if (dto == null)
                return;

            if (dgvStudentiPretraga.CurrentCell is DataGridViewButtonCell)
            {
                var frmUvjerenja = new frmUvjerenjaIB230123(dto.StudentId);
                frmUvjerenja.ShowDialog();
            }
            else
            {
                var frmStudentInfo = new frmStudentInfoIB230123(dto);
                frmStudentInfo.ShowDialog();
            }
        }
    }
}
