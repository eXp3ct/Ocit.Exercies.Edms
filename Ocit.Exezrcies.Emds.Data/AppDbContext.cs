using Microsoft.EntityFrameworkCore;
using Ocit.Exercies.Emds.Domain;
using Ocit.Exezrcies.Emds.Data.Interfaces;
using Ocit.Exezrcies.Emds.Data.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ocit.Exezrcies.Emds.Data
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<BasicDocument> BasicDocuments { get; set; }
        public DbSet<IncomingDocument> IncomingDocuments { get; set; }
        public DbSet<Addresse> Addresses { get; set; }
        public DbSet<CounterParty> CounterParties { get; set; }
        public DbSet<CameFrom> CameFroms { get; set; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; set; }

        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Host=localhost;Port=5432;Database=postgres;Username=root;Password=root;";

            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);
        }
    }
}
