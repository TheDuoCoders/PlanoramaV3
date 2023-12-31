using System.Data.Entity;

namespace DAL.Models
{
    public class EMSContext : DbContext
    {
        public DbSet<FoodsCategory> FoodsCategories { get; set;}
        public DbSet<Food> Foods { get; set;}
        public DbSet<DecorationsCategory> DecorationsCategories {  get; set;}
        public DbSet<Dacoration> Decorations { get; set; }
        public DbSet<LocationsCategory> LocationsCategories { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}