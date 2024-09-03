namespace WinForms.Exercise.Data.Ispit31._08._2021
{
    public class PolozeniPredmetIB230004
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public StudentIB230004 Student { get; set; }
        public int PredmetId { get; set; }
        public PredmetIB230004 Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public string Napomena { get; set; }
    }
}