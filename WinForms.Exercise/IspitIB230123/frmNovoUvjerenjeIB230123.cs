using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Exercise.Data.IspitIB230123;
using WinForms.Exercise.Helpers;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.IspitIB230123
{
    public partial class frmNovoUvjerenjeIB230123 : Form
    {
        private readonly DLWMSDbContext _dbContext = new();
        private int _studentId;
        public frmNovoUvjerenjeIB230123(int studentId)
        {
            InitializeComponent();

            _studentId = studentId;
        }

        private void pbUplatnica_Click(object sender, EventArgs e)
        {
            UcitajUplatnicu();
        }

        private void UcitajUplatnicu()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos())
                return;

            var novoUvjerenje = new StudentUvjerenjeIB230123()
            {
                VrstaUvjerenja = cmbVrstaUvjerenja.Text,
                SvrhaUvjerenja = txtSvrhaIzdavanja.Text,
                Uplatnica = pbUplatnica.Image.ToBytes(),
                Printano = false,
                VrijemeKreiranja = DateTime.Now,
                StudentId = _studentId
            };

            _dbContext.StudentiUvjerenjaIB230123.Add(novoUvjerenje);
            _dbContext.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(cmbVrstaUvjerenja, errorProvider, "Obavezna vrijednost") &&
                Validator.ProvjeriUnos(txtSvrhaIzdavanja, errorProvider, "Obavezna vrijednost") &&
                Validator.ProvjeriUnos(pbUplatnica, errorProvider, "Obavezna vrijednost");
        }
    }
}
