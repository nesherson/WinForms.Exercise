namespace WinForms.Exercise.Data.Ispit18._02._2021
{
    public class StudentCovidTestIB230125
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public StudentIB230125 Student { get; set; }
        public string Rezultat { get; set; }
        public DateTime Datum { get; set; }
        public bool NalazDostavljen { get; set; }
    }
}
