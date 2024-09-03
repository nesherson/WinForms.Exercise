namespace WinForms.Exercise.Data.Ispit31._08._2021
{
    public class StudentIspitScanIB230004
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public StudentIB230004 Student { get; set; }
        public PredmetIB230004 Predmet { get; set; }
        public string Napomena { get; set; }
        public bool Varanje { get; set; }
        public byte[]? SkeniranIspit { get; set; }
    }
}