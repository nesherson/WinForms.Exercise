namespace WinForms.Exercise.Data.Ispit01._02._2024
{
    public class PolozeniPredmetIB230002
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public StudentIB230002 Student { get; set; }
        public int PredmetId { get; set; }
        public PredmetIB230002 Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public string Napomena { get; set; }
    }
}