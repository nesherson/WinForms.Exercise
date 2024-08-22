namespace WinForms.Exercise.Data.Ispit18._02._2021
{
    public class PolozeniPredmetIB230125
    {
        public int Id { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public int Ocjena { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public StudentIB230125 Student { get; set; }
        public Predmet Predmet { get; set; }
    }
}
