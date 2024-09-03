namespace WinForms.Exercise.Data.Ispit31._08._2021
{
    public class PredmetIB230004
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