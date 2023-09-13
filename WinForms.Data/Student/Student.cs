namespace WinForms.Data
{
    public class Student
    {
        public Student()
        {
            Role = new HashSet<Role>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IndexNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Active { get; set; }
        public byte[]? Image { get; set; }
        public string Password { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public ICollection<Role> Role { get; set; }

        public string FirstLastName => $"{FirstName} {LastName}";
    }   
}
