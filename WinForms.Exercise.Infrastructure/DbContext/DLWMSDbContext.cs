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

        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Spol> Spolovi { get; set; }

        //Ispiti
    }
}   