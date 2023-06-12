using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Yummy.Models;

namespace Yummy.DAL
{
    public class YummyDBContext : DbContext
    {
        public YummyDBContext (DbContextOptions<YummyDBContext> options) : base (options) {}

        public DbSet<Category> Categories { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<MealIngredient> MealIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MealIngredient>().HasKey(x => new { x.MealId, x.IngredientId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
