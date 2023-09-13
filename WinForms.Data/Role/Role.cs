namespace WinForms.Data
{
    public class Role
    {
        public Role()
        {
            Student = new HashSet<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Student { get; set; }
    }
}
