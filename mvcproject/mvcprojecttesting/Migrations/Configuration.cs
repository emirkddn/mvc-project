namespace mvcprojecttesting.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using mvcprojecttesting.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<mvcprojecttesting.Entity.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(mvcprojecttesting.Entity.DataContext context)
        {
            context.Products.AddOrUpdate(
                p => p.Name
            );
        }
    }
}
