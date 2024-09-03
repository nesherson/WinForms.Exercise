namespace WinForms.Exercise.Data.Ispit31._08._2021
{
    public class StudentIB230004
    {
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
        public SemestarIB230004 Semestar { get; set; }

        public List<PolozeniPredmetIB230004> PolozeniPredmetIB230004 { get; set; }
    }
}