using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using mvcprojecttesting.Entity;
using mvcprojecttesting.Identity;

namespace mvcprojecttesting.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ikiikidortDb")
        {
            Database.SetInitializer(new DataInitializater());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}