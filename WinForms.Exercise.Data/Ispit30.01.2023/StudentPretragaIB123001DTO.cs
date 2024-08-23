using System.Drawing;

namespace WinForms.Exercise.Data.Ispit30._01._2023
{
	public class StudentPretragaIB123001DTO
	{
        public int StudentId { get; set; }
        public string ImePrezime { get; set; }
        public string BrojIndeksa { get; set; }
        public float Prosjek { get; set; }
        public bool Aktivan { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Image? Slika { get; set; }
    }
}
