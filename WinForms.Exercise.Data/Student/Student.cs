using WinForms.Exercise.Data.Ispit30._01._2023;

namespace WinForms.Exercise.Data
{
	public class Student
    {
        public Student()
        {
            StudentUvjerenjaIB123001 = new();
        }
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }   
        public string Indeks { get; set; }
        public bool Aktivan { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public byte[]? Slika { get; set; }
        public int SpolId { get; set; }
        public Spol Spol { get; set; }
		public int SemestarId { get; set; }
		public Spol Semestar { get; set; }

		public List<PolozeniPredmet> PolozeniPredmeti { get; set; }
        public List<StudentUvjerenjeIB123001> StudentUvjerenjaIB123001 { get; set; }
    }
}