namespace WinForms.Exercise.Data
{
    public class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}