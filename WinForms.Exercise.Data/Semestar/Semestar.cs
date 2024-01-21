namespace WinForms.Exercise.Data
{
    public class Semestar
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }

        public override string ToString()
        {
            return Oznaka;
        }
    }
}