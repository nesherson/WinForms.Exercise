using System.Drawing;

namespace WinForms.Exercise.Data.IspitIB230123
{
    public class dtoStudentPretragaIB230123
    {
        public int StudentId { get; set; }
        public string ImePrezime { get; set; }
        public string BrojIndeksa { get; set; }
        public decimal Prosjek { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }
        public Image Slika { get; set; }
    }
}
