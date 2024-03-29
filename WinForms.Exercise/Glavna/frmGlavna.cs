﻿using WinForms.Exercise.Asinhrono;
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
    }
}