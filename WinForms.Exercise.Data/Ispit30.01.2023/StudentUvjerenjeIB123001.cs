namespace WinForms.Exercise.Data.Ispit30._01._2023
{
	public class StudentUvjerenjeIB123001
	{
        public int Id { get; set; }
        public int StudentId { get; set; }
        public StudentIB123001 Student { get; set; }
        public string VrstaUvjerenja { get; set; }
        public string SvrhaUvjerenja { get; set; }
        public byte[]? Uplatnica { get; set; }
        public bool Printano { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
    }
}
