using Sample.Core.Common.Data.Extensions;
using Sample.Core.Recipes.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Sample.Core.Recipes.Data.Context
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Recipes");
            modelBuilder.RemovePluralizingTableNameConvention();
        }
    }
}