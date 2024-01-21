namespace WinForms.Exercise.Data.DTO
{
    public class dtoStudentUvjerenje
    {
        public string ImePrezime { get; set; }
        public string BrojIndeksa { get; set; }
        public string Svrha { get; set; }
        public string Status { get; set; }
        public string AkademskaGodina { get; set; }
        public List<PolozeniPredmet> PolozeniPredmeti { get; set; }
    }
}
