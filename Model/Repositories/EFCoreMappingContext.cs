
using System.Collections.Generic;
using System.Text;
using Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace Model.Repositories
{
    public class EFCoreMappingContext : DbContext
    {
        public static IConfigurationRoot configuration;
        bool testMode = false;
        // Complex Type
        public DbSet<Campus> Campussen { get; set; }
        public DbSet<Docent> Docenten { get; set; }
        // Inheritance: TPH
        public DbSet<TPHCursus> TPHCursussen { get; set; }
        // ------------
        // Constructors
        // ------------
        public EFCoreMappingContext() { }
        public EFCoreMappingContext(DbContextOptions<EFCoreMappingContext> options) : base(options) { }
        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging
            (
            builder => builder.AddConsole()
            .AddFilter(DbLoggerCategory.Database.Command.Name,
            LogLevel.Information)
            );
            return serviceCollection.BuildServiceProvider().GetService<ILoggerFactory>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Zoek de naam in de connectionStrings section - appsettings.json
                configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName) 
               .AddJsonFile("appsettings.json", false)
                .Build();
                var connectionString = configuration.GetConnectionString("efcoremapping");
                if (connectionString != null) // Indien de naam is gevonden
                {
                    optionsBuilder.UseSqlServer(
                    connectionString,
                    options => options.MaxBatchSize(150)) // Max aantal SQLcommands die kunnen doorgestuurd worden naar de database
                    .UseLoggerFactory(GetLoggerFactory())
                    .EnableSensitiveDataLogging(true); // Toont de waarden van de parameters bij de logging
                    //.UseLazyLoadingProxies();
                }
            }
            else
            {
                testMode = true;
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // -----
            // Adres
            // -----
            // -----
            //modelBuilder.Entity<Campus>().OwnsOne(s => s.Adres).ToTable("CampusAdressen");
            //modelBuilder.Entity<Docent>().OwnsOne(s => s.AdresThuis).ToTable("DocentAdressenThuis");
            //modelBuilder.Entity<Docent>().OwnsOne(s => s.AdresWerk).ToTable("DocentAdressenWerk");
            // Voor campus
            modelBuilder.Entity<Campus>().OwnsOne(s => s.Adres);
            modelBuilder.Entity<Campus>().OwnsOne(s => s.Adres).Property(b => b.Straat).HasColumnName("Straat");
            modelBuilder.Entity<Campus>().OwnsOne(s => s.Adres).Property(b => b.Huisnummer).HasColumnName("HuisNr");
            modelBuilder.Entity<Campus>().OwnsOne(s => s.Adres).Property(b => b.Postcode).HasColumnName("PostCd");
            modelBuilder.Entity<Campus>().OwnsOne(s => s.Adres).Property(b => b.Gemeente).HasColumnName("Gemeente");
            // Voor Docent
            modelBuilder.Entity<Docent>().OwnsOne(s => s.AdresThuis);
            modelBuilder.Entity<Docent>().OwnsOne(s => s.AdresThuis).Property(b => b.Gemeente)
            .HasColumnName("GemeenteThuis");
            modelBuilder.Entity<Docent>().OwnsOne(s => s.AdresThuis).Property(b => b.Huisnummer)
            .HasColumnName("HuisNrThuis");
            modelBuilder.Entity<Docent>().OwnsOne(s => s.AdresThuis).Property(b => b.Postcode)
            .HasColumnName("PostCdThuis");
            modelBuilder.Entity<Docent>().OwnsOne(s => s.AdresThuis).Property(b => b.Straat)
            .HasColumnName("StraatThuis");
            modelBuilder.Entity<Docent>().OwnsOne(s => s.AdresWerk);
            modelBuilder.Entity<Docent>().OwnsOne(s => s.AdresWerk).Property(b => b.Gemeente)
            .HasColumnName("GemeenteWerk");
            modelBuilder.Entity<Docent>().OwnsOne(s => s.AdresWerk).Property(b => b.Huisnummer)
            .HasColumnName("HuisNrWerk");
            modelBuilder.Entity<Docent>().OwnsOne(s => s.AdresWerk).Property(b => b.Postcode)
            .HasColumnName("PostCdWerk");
            modelBuilder.Entity<Docent>().OwnsOne(s => s.AdresWerk).Property(b => b.Straat)
            .HasColumnName("StraatWerk");
            // ------
            // Docent
            // ------
            modelBuilder.Entity<Model.Entities.Docent>().ToTable("Docenten");
            modelBuilder.Entity<Docent>().HasKey(c => c.DocentId);
            modelBuilder.Entity<Docent>().Property(b => b.DocentId)
            .ValueGeneratedOnAdd();
            modelBuilder.Entity<Docent>().Property(b => b.Voornaam)
            .IsRequired()
            .HasMaxLength(20);
            modelBuilder.Entity<Docent>().Property(b => b.Familienaam)
            .IsRequired()
            .HasMaxLength(30);
            modelBuilder.Entity<Docent>().Property(b => b.Wedde)
            .HasColumnName("Maandwedde")
            .HasColumnType("decimal(18, 4)");
            modelBuilder.Entity<Docent>().Property(b => b.InDienst)
            .HasColumnType("date");
            modelBuilder.Entity<Docent>().HasOne(b => b.Campus)
        .WithMany(c => c.Docenten)
        .HasForeignKey(b => b.CampusId);
            // ------
            // Campus
            // ------
            modelBuilder.Entity<Campus>().ToTable("Campussen");
            modelBuilder.Entity<Campus>().HasKey(c => c.CampusId);
            modelBuilder.Entity<Campus>().Property(b => b.CampusId)
            .ValueGeneratedOnAdd();
            modelBuilder.Entity<Campus>().Property(b => b.Naam)
            .HasColumnName("CampusNaam")
            .IsRequired();
            modelBuilder.Entity<Campus>().Ignore(c => c.Commentaar);
        }
    }
}
