using HA.Domain.Enitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Zone> Zones { get; set; }
        public DbSet<PriceMultiplier> PriceMultipliers { get; set; }
        public DbSet<SurveyFirst> FirstSurveys { get; set; }
        public DbSet<ThresholdFirst> FirstThresholds { get; set; }
        public DbSet<ThresholdSecond> SecondThresholds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //

            modelBuilder.Entity<SurveyFirst>().HasData(new SurveyFirst
            {
                Id = Guid.Parse("094234BEB6C7438AAE175FA53324F5BB"),
                Survey = "21"
            });

            modelBuilder.Entity<SurveySecond>().HasData(new SurveySecond
            {
                Id = Guid.Parse("2B9B964F85EF4E248BD339CD8198AAF8"),
                Survey = "62"
            });

            //

            modelBuilder.Entity<ThresholdFirst>().HasData(new ThresholdFirst
            {
                Id = Guid.Parse("5427565F60BE4644A617590DE1355544"),
                Level = 60
            });

            modelBuilder.Entity<ThresholdFirst>().HasData(new ThresholdFirst
            {
                Id = Guid.Parse("792AAEDA61A544EAB357718B9DA5CA10"),
                Level = 100
            });

            modelBuilder.Entity<ThresholdFirst>().HasData(new ThresholdFirst
            {
                Id = Guid.Parse("D3346656A7B243A9A23E6AC4E5BFF879"),
                Level = 140
            });

            modelBuilder.Entity<ThresholdFirst>().HasData(new ThresholdFirst
            {
                Id = Guid.Parse("2F04EE1148AE45E5AFCCF32BABEEBE38"),
                Level = 200
            });

            //

            modelBuilder.Entity<ThresholdSecond>().HasData(new ThresholdSecond
            {
                Id = Guid.Parse("ADA398464E684A4FA219CA6BCEFDA46C"),
                Level = 36
            });

            modelBuilder.Entity<ThresholdSecond>().HasData(new ThresholdSecond
            {
                Id = Guid.Parse("45EB5A2CF47A47D78BBF881AC5B58909"),
                Level = 60
            });

            modelBuilder.Entity<ThresholdSecond>().HasData(new ThresholdSecond
            {
                Id = Guid.Parse("8B778CE79CDA4C45B8D723C02AE6A4AF"),
                Level = 84
            });

            modelBuilder.Entity<ThresholdSecond>().HasData(new ThresholdSecond
            {
                Id = Guid.Parse("DB814F8001544E71A787625487EA2BBC"),
                Level = 120
            });

            //

            modelBuilder.Entity<Zone>().HasData(new Zone
            { 
                Id = Guid.Parse("F610E3DEA68649878BCF457C009FD47F"),
                ZoneName = "S1",
                SurveyFirstId = Guid.Parse("094234BEB6C7438AAE175FA53324F5BB"),
                SurveySecondId = Guid.Parse("2B9B964F85EF4E248BD339CD8198AAF8"),
                DefaultPrice = 3.50M
            });
        }

    }
}
