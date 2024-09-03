using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WinForms.Exercise.Data;
using WinForms.Exercise.Data.Ispit01._02._2024;
using WinForms.Exercise.Data.Ispit22._02._2024;
using WinForms.Exercise.Data.Ispit30._01._2023;
using WinForms.Exercise.Data.Ispit31._08._2021;

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

        //Ispit 01.02.2024

        public DbSet<StudentIB230002> StudentiIB230002 { get; set; }
        public DbSet<SpolIB230002> SpoloviIB230002 { get; set; }
        public DbSet<DrzavaIB230002> DrzaveIB230002 { get; set; }
        public DbSet<GradIB230002> GradoviIB230002 { get; set; }
        public DbSet<PolozeniPredmetIB230002> PolozeniPredmetiIB230002 { get; set; }
        public DbSet<PredmetIB230002> PredmetiIB230002 { get; set; }

        //Ispit 22.02.2024

        public DbSet<ProstorijaIB230003> ProstorijeIB230003 { get; set; }
        public DbSet<NastavaIB230003> NastavaIB230003 { get; set; }
        public DbSet<PrisustvoIB230003> PrisustvaIB230003 { get; set; }
        public DbSet<PredmetIB230003> PredmetiIB230003 { get; set; }
        public DbSet<StudentIB230003> StudentiIB230003 { get; set; }

        //Ispit 31.08.2021

        public DbSet<PredmetIB230004> PredmetiIB230004 { get; set; }
        public DbSet<StudentIB230004> StudentiIB230004 { get; set; }
        public DbSet<SpolIB230004> SpoloviIB230004 { get; set; }
        public DbSet<PolozeniPredmetIB230004> PolozeniPredmetiIB230004 { get; set; }
        public DbSet<StudentIspitScanIB230004> StudentiIspitiScanIB230004 { get; set; }
    }
}