using WinForms.Exercise.Asinhrono;
using WinForms.Exercise.Ispit31._08._2021;
using WinForms.Exercise.IspitIB230123;
using WinForms.Exercise.Studenti;

namespace WinForms.Exercise.Glavna
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void krajRadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmStudentiPretraga());
        }

        private void PrikaziFormu(Form forma)
        {
            forma.MdiParent = this;
            forma.Show();
        }

        private void noviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmStudentNovi());
        }

        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmPing());
        }

        private void ispit30012023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmPretragaIB230123());
        }

        private void ispitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmPretragaIB230124());
        }
    }
}