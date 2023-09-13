using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WinForms.Data.Auth;

namespace WinForms.Data.Context
{
    public class WinFormsExerciseDbContext : DbContext
    {
        private readonly string putanja;

        public WinFormsExerciseDbContext()
        {
            putanja = ConfigurationManager.ConnectionStrings["dbPath"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(putanja);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Role)
                .WithMany(r => r.Student)
                .UsingEntity(e => e.ToTable("StudentsRoles"));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentsSubjects { get; set; }

    }
}