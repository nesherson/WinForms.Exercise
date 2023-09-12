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

        public DbSet<User> Users { get; set; }
    }
}