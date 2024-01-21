using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}