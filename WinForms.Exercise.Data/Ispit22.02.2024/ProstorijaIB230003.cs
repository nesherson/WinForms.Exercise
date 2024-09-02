namespace WinForms.Exercise.Data.Ispit22._02._2024
{
    public class ProstorijaIB230003
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
        public byte[]? Logo { get; set; }
        public int Kapacitet { get; set; }

        public List<NastavaIB230003> NastavaIB230003 { get; set; }
    }
}