namespace WinForms.Exercise.Data.Ispit30._01._2023
{
	public class PolozeniPredmetIB123001
	{
        public int Id { get; set; }
        public int StudentId { get; set; }
        public StudentIB123001 Student { get; set; }
        public int PredmetId { get; set; }
        public Predmet Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public string Napomena { get; set; }
    }
}
