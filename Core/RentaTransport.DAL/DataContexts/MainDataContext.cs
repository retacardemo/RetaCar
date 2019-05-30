using System.Linq;
using Microsoft.EntityFrameworkCore;
using RentaTransport.DAL.DAOs;

namespace RentaTransport.DAL.DataContexts
{
    public class MainDataContext: DbContext
    {
        public MainDataContext(DbContextOptions<MainDataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var entities = modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys());
            foreach (var relationship in entities)
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }

        public DbSet<CarDAO> Cars { get; set; }
        public DbSet<CarAdditionDAO> CarAdditions { get; set; }
        public DbSet<CarImageDAO> CarImages { get; set; }
        public DbSet<BrandDAO> Brands { get; set; }
        public DbSet<ModelDAO> Models { get; set; }
        public DbSet<FuelTypeDAO> FuelTypes { get; set; }
        public DbSet<BanTypeDAO> BanTypes { get; set; }
        public DbSet<ColorDAO> Colors { get; set; }
        public DbSet<CityDAO> Cities { get; set; }
        public DbSet<CustomerPhoneNumberDAO> CustomerPhoneNumbers { get; set; }
    }
}
