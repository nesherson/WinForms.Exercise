using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.Ispit31._08._2021
{
    public partial class frmScanIspitaIB230124 : Form
    {
        private readonly DLWMSDbContext _dbContext = new();

        private int _studentId;
        public frmScanIspitaIB230124(int studentId)
        {
            InitializeComponent();

            dgvStudentiIspitiScan.AutoGenerateColumns = false;

            _studentId = studentId;
        }

        private void frmScanIspitaIB230124_Load(object sender, EventArgs e)
        {
            UcitajStudentiIspitiScan();
        }

        private void UcitajStudentiIspitiScan()
        {
            dgvStudentiIspitiScan.DataSource = null;
            dgvStudentiIspitiScan.DataSource = _dbContext
                .StudentiIspitiScanIB230124
                .Include(si => si.Predmet)
                .Where(x => x.StudentId == _studentId)
                .ToList();
        }

        private void btnDodajScanIspita_Click(object sender, EventArgs e)
        {
            var frmNoviScanIspita = new frmNoviScanIspitaIB230140(_studentId);
            if (frmNoviScanIspita.ShowDialog() == DialogResult.OK)
                UcitajStudentiIspitiScan();
        }
    }
}
