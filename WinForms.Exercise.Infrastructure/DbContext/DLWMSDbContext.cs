using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WinForms.Exercise.Data;

namespace WinForms.Exercise.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["DLWMSBaza"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Uloga)
                .WithMany(u => u.Student)
                .UsingEntity(t => t.ToTable("StudentiUloge"));
        }

        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Semestar> Semestri { get; set; }
        public DbSet<Uloga> Uloge { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<PolozeniPredmet> PolozeniPredmeti { get; set; }
    }
}