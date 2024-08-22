namespace WinForms.Exercise.Data.Ispit31._08._2021
{
    public class StudentIspitScanIB230124
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public string Napomena { get; set; }
        public byte[] SkeniranIspit { get; set; }
        public bool Varanje { get; set; }
        public Predmet Predmet { get; set; }
    }
}
