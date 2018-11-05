using BackendPizzeria.Domain;

namespace BackendPizzeria.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PizzaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        
        protected override void Seed(PizzaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Ingredient[] listaInicial = new Ingredient[]
            {
                new Ingredient {Id = 1, Name = "TomateFrito", Price = 0.7M},
                new Ingredient {Id = 2, Name = "Queso", Price = 1.05M},
                new Ingredient {Id = 3, Name = "Oregano", Price = 0.2M},
                new Ingredient {Id = 4, Name = "Masa de pizza", Price = 1.5M}
            };

            

            if (!context.Ingredients.Any())
            {
                context.Ingredients.AddOrUpdate(listaInicial);
            }


        }
    }
}
