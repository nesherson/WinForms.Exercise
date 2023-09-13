using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Exercise
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmStudentEdit());
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmStudentSearch());
        }

        private void searchExam120923ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmStudentSearchExam120923());
        }

        private void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm(new frmSubjectEdit());
        }
    }
}
