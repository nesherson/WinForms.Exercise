namespace WinForms.Exercise.Data.Ispit01._02._2024
{
    public class DrzavaIB230002
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public byte[]? Zastava { get; set; }

        public List<GradIB230002> GradIB230002 { get; set; }
    }
}