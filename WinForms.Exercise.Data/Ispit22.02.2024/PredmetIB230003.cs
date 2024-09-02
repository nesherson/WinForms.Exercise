namespace WinForms.Exercise.Data.Ispit01._02._2024
{
    public class PredmetIB230003
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int SemestarId { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}