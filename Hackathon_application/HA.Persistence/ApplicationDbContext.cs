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
        public DbSet<SurveyFirst> SecondSurveys { get; set; }
        public DbSet<ThresholdFirst> FirstThresholds { get; set; }
        public DbSet<ThresholdSecond> SecondThresholds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //
            //1.1
            modelBuilder.Entity<SurveyFirst>().HasData(new SurveyFirst
            {
                Id = Guid.Parse("094234BEB6C7438AAE175FA53324F5BB"),
                Survey = "21"
            });
            //1.2
            modelBuilder.Entity<SurveySecond>().HasData(new SurveySecond
            {
                Id = Guid.Parse("2B9B964F85EF4E248BD339CD8198AAF8"),
                Survey = "62"
            });
            //1.3
            modelBuilder.Entity<SurveyFirst>().HasData(new SurveyFirst
            {
                Id = Guid.Parse("80D8E42EDD52463E823DB9A0B887530B"),
                Survey = "180"
            });
            //1.4
            modelBuilder.Entity<SurveySecond>().HasData(new SurveySecond
            {
                Id = Guid.Parse("010067D643B24F19BA0F40A175BD8185"),
                Survey = "250"
            });
            //1.5
            modelBuilder.Entity<SurveyFirst>().HasData(new SurveyFirst
            {
                Id = Guid.Parse("CF680241854C48F2925CD15C49ED1AF1"),
                Survey = "87"
            });
            //1.6
            modelBuilder.Entity<SurveySecond>().HasData(new SurveySecond
            {
                Id = Guid.Parse("DEDDF733AB674737A7B6EC17A6E4B3AD"),
                Survey = "19"
            });
            //1.7
            modelBuilder.Entity<SurveyFirst>().HasData(new SurveyFirst
            {
                Id = Guid.Parse("990B0236B37741F3BB06BDAEC289BE2D"),
                Survey = "137"
            });
            //1.8
            modelBuilder.Entity<SurveySecond>().HasData(new SurveySecond
            {
                Id = Guid.Parse("CBE23EFD4DBB4CD4B83AAE353DB0D954"),
                Survey = "300"
            });
            //1.9
            modelBuilder.Entity<SurveySecond>().HasData(new SurveySecond
            {
                Id = Guid.Parse("B2AF4BB0708E4B908A90E1C25A28E9FA"),
                Survey = "1"
            });
            //2.1
            modelBuilder.Entity<SurveyFirst>().HasData(new SurveyFirst
            {
                Id = Guid.Parse("B4682943DED9435BA68945D5103B6F33"),
                Survey = "45"
            });
            //2.2
            modelBuilder.Entity<SurveySecond>().HasData(new SurveySecond
            {
                Id = Guid.Parse("ED26E72B1C7248BEAEA7898C49B5952D"),
                Survey = "26"
            });
            //2.3
            modelBuilder.Entity<SurveyFirst>().HasData(new SurveyFirst
            {
                Id = Guid.Parse("79BFC18677754C4F83E16B5416D59A50"),
                Survey = "56"
            });
            //2.4
            modelBuilder.Entity<SurveySecond>().HasData(new SurveySecond
            {
                Id = Guid.Parse("FD931C8BDF99431E926725F0FF4E37E4"),
                Survey = "68"
            });
            //2.5
            modelBuilder.Entity<SurveyFirst>().HasData(new SurveyFirst
            {
                Id = Guid.Parse("240D13E3719A487FBB69D807498C0302"),
                Survey = "49"
            });
            //2.6
            modelBuilder.Entity<SurveySecond>().HasData(new SurveySecond
            {
                Id = Guid.Parse("65E416BF15D744B29D007832B177496B"),
                Survey = "15"
            });
            //2.7
            modelBuilder.Entity<SurveyFirst>().HasData(new SurveyFirst
            {
                Id = Guid.Parse("2B2B48D9EE3148F4A49565AF6C8F8859"),
                Survey = "125"
            });
            //2.8
            modelBuilder.Entity<SurveySecond>().HasData(new SurveySecond
            {
                Id = Guid.Parse("3BA78A8FFE794AD9B414545ED0F51CBB"),
                Survey = "157"
            });
            //2.9
            modelBuilder.Entity<SurveySecond>().HasData(new SurveySecond
            {
                Id = Guid.Parse("4F9711823A724E288BE2118555B01606"),
                Survey = "0"
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
            //.1
            modelBuilder.Entity<Zone>().HasData(new Zone
            { 
                Id = Guid.Parse("F610E3DEA68649878BCF457C009FD47F"),//encje.txt
                ZoneName = "S1",
                SurveyFirstId = Guid.Parse("094234BEB6C7438AAE175FA53324F5BB"),//1.1
                SurveySecondId = Guid.Parse("B4682943DED9435BA68945D5103B6F33"),//2.1
                DefaultPrice = 3.50M
            });
            //.2
            modelBuilder.Entity<Zone>().HasData(new Zone
            {
                Id = Guid.Parse("19752857EA39422990F8A14F0695B042"),
                ZoneName = "S2",
                SurveyFirstId = Guid.Parse("2B9B964F85EF4E248BD339CD8198AAF8"),
                SurveySecondId = Guid.Parse("ED26E72B1C7248BEAEA7898C49B5952D"),
                DefaultPrice = 3.50M
            });
            //.3
            modelBuilder.Entity<Zone>().HasData(new Zone
            {
                Id = Guid.Parse("0363C650FC4F4DF4B0A4912DC7CA3151"),
                ZoneName = "S3",
                SurveyFirstId = Guid.Parse("80D8E42EDD52463E823DB9A0B887530B"),
                SurveySecondId = Guid.Parse("79BFC18677754C4F83E16B5416D59A50"),
                DefaultPrice = 3.50M
            });
            //.4
            modelBuilder.Entity<Zone>().HasData(new Zone
            {
                Id = Guid.Parse("043CE18440894614BAC8A1BD300C8A7C"),
                ZoneName = "S4",
                SurveyFirstId = Guid.Parse("010067D643B24F19BA0F40A175BD8185"),
                SurveySecondId = Guid.Parse("FD931C8BDF99431E926725F0FF4E37E4"),
                DefaultPrice = 4.50M
            });
            //.5
            modelBuilder.Entity<Zone>().HasData(new Zone
            {
                Id = Guid.Parse("68EF94103A7C443DAB0C1E2B15939415"),
                ZoneName = "S5",
                SurveyFirstId = Guid.Parse("CF680241854C48F2925CD15C49ED1AF1"),
                SurveySecondId = Guid.Parse("240D13E3719A487FBB69D807498C0302"),
                DefaultPrice = 4.50M
            });
            //.6
            modelBuilder.Entity<Zone>().HasData(new Zone
            {
                Id = Guid.Parse("7EE1120989FC43619D647941A21BAA23"),
                ZoneName = "S6",
                SurveyFirstId = Guid.Parse("DEDDF733AB674737A7B6EC17A6E4B3AD"),
                SurveySecondId = Guid.Parse("65E416BF15D744B29D007832B177496B"),
                DefaultPrice = 4.50M
            });
            //.7
            modelBuilder.Entity<Zone>().HasData(new Zone
            {
                Id = Guid.Parse("8FD9EC8F2BC34F369D700E6AD5B10B14"),
                ZoneName = "S7",
                SurveyFirstId = Guid.Parse("990B0236B37741F3BB06BDAEC289BE2D"),
                SurveySecondId = Guid.Parse("2B2B48D9EE3148F4A49565AF6C8F8859"),
                DefaultPrice = 6.00M
            });
            //.8
            modelBuilder.Entity<Zone>().HasData(new Zone
            {
                Id = Guid.Parse("3529A503C48F47ADAD439FDCB8744D89"),
                ZoneName = "S8",
                SurveyFirstId = Guid.Parse("CBE23EFD4DBB4CD4B83AAE353DB0D954"),
                SurveySecondId = Guid.Parse("3BA78A8FFE794AD9B414545ED0F51CBB"),
                DefaultPrice = 6.00M
            });
            //.9
            modelBuilder.Entity<Zone>().HasData(new Zone
            {
                Id = Guid.Parse("CF169ADBCDCD4F2E963534B48235FBA5"),
                ZoneName = "S9",
                SurveyFirstId = Guid.Parse("B2AF4BB0708E4B908A90E1C25A28E9FA"),
                SurveySecondId = Guid.Parse("4F9711823A724E288BE2118555B01606"),
                DefaultPrice = 6.00M
            });
        }

    }
}
