using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BackendPizzeria.Domain
{
    public class PizzaContext : DbContext, IPizzaContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public IDbSet<Pizza> Pizzas
        {
            get
            {
                return base.Set<Pizza>();                
            }
        }

        public PizzaContext() : base("name=BackendPizzeria")
        {

        }

        public void Commit()
        {
            base.SaveChanges();
        }

        public void Rollback()
        {
            base.ChangeTracker.Entries().ToList().ForEach(en => en.State = EntityState.Unchanged);
        }

        public new void Dispose()
        {
            base.Dispose();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Commentary>()
                .HasRequired<Pizza>(s => s.Pizza)
                .WithMany(g => g.Commentaries)
                .HasForeignKey<int>(s => s.PizzaId);
        }
    }
}
