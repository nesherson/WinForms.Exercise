using WinForms.Exercise.Data.Ispit01._02._2024;

namespace WinForms.Exercise.Data.Ispit22._02._2024
{
    public class PrisustvoIB230003
    {
        public int Id { get; set; }
        public int NastavaId { get; set; }
        public NastavaIB230003 Nastava { get; set; }
        public int StudentId { get; set; }
        public StudentIB230003 Student { get; set; }
    }
}