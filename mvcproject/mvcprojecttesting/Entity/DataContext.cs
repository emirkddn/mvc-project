using System.Data.Entity;
using mvcprojecttesting.Entity;

namespace mvcprojecttesting.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("selamdb")
        {
            Database.SetInitializer(new DataInitializater());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}