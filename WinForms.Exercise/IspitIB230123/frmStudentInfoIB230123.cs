using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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
using WinForms.Exercise.Infrastructure;

namespace WinForms.Exercise.IspitIB230123
{
    public partial class frmStudentInfoIB230123 : Form
    {
        private readonly DLWMSDbContext _dbContext = new();
        private dtoStudentPretragaIB230123 _studentDto;
        public frmStudentInfoIB230123(dtoStudentPretragaIB230123 studentDto)
        {
            InitializeComponent();

            _studentDto = studentDto;
        }

        private void frmStudentInfoIB230123_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentu();
        }

        private void UcitajPodatkeOStudentu()
        {
            pbSlika.Image = _studentDto.Slika;
            lblImePrezime.Text = _studentDto.ImePrezime;
            lblProsjek.Text = _studentDto.Prosjek.ToString();
        }

    }
}
