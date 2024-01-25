using FIT.Data;
using FIT.Data.IspitIB180079;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<PredmetIiIB180079> Predmeti { get; set; }
        public DbSet<SemestriIB180079> Semestri { get; set; }
        public DbSet<PolozeniPredmetiIB180079> PolozeniPredmeti { get; set; }
        public DbSet<StudentiUvjerenjaIB180079> StudentiUvjerenjaIB180079 { get; set; }
    }
}