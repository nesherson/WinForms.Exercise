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
    

		//ISPITI

        //Ispit 30.01.2023
        public DbSet<StudentUvjerenjeIB123001> StudentiUvjerenjaIB123001 { get; set; }
		public DbSet<StudentIB123001> StudentiIB123001 { get; set; }
		public DbSet<SpolIB123001> SpoloviIB123001 { get; set; }
		public DbSet<PolozeniPredmetIB123001> PolozeniPredmetiIB123001 { get; set; }
	}
}   