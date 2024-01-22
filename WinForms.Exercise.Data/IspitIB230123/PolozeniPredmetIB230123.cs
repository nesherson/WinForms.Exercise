namespace WinForms.Exercise.Data.IspitIB230123
{
    public class PolozeniPredmetIB230123
    {
        public int Id { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public int Ocjena { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public Student Student { get; set; }
        public Predmet Predmet { get; set; }
    }
}
