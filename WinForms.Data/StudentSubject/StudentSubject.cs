using System.ComponentModel.DataAnnotations.Schema;

namespace WinForms.Data
{
    [Table("StudentsSubjects")]
    public class StudentSubject
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }
    }
}
