namespace WinForms.Exercise.Data.Ispit31._08._2021
{
    public class PolozeniPredmetIB230124
    {
        public int Id { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public int Ocjena { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public StudentIB230124 Student { get; set; }
        public Predmet Predmet { get; set; }
    }
}
