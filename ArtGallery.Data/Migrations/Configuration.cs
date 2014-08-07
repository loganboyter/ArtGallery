namespace ArtGallery.Data.Migrations
{
    using ArtGallery.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ArtGallery.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ArtGallery.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Artists.AddOrUpdate(
                a => a.Name, 
                new Artist("Van Gough", "Cut off his ear"), 
                new Artist("Leonardo da Vinci", "Itialian Renaissance polymath"), 
                new Artist("Edvard Munch", "Norweigan")
                );
        }
    }
}
