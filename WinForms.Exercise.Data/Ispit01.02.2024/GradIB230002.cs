namespace WinForms.Exercise.Data.Ispit01._02._2024
{
    public class GradIB230002
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public int DrzavaId { get; set; }
        public DrzavaIB230002 Drzava { get; set; }
    }
}