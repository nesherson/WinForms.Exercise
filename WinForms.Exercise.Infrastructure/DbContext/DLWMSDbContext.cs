using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WinForms.Exercise.Data;
using WinForms.Exercise.Data.Ispit30._01._2023;

namespace WinForms.Exercise.Infrastructure
{
	public class DLWMSDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["DLWMSBaza"].ConnectionString);
        }

        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<PolozeniPredmet> PolozeniPredmeti { get; set; }

		//Ispiti

        public DbSet<StudentUvjerenjeIB123001> StudentiUvjerenjaIB123001 { get; set; }
	}
}   