using food_recipes_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace food_recipes_api.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Diet> Diet { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=food-recipes;database=food-recipes";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 33));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
