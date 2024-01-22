namespace WinForms.Exercise.Data.IspitIB230123
{
    public class StudentUvjerenjeIB230123
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
        public string VrstaUvjerenja { get; set; }
        public string SvrhaUvjerenja { get; set; }
        public bool Printano { get; set; }
        public byte[] Uplatnica { get; set; }
        public StudentIB230123 Student { get; set; }
    }
}
