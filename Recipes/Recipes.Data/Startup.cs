using Sample.Core.Recipes.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.Core.Recipes.Data
{
    public static class Startup
    {
        public static void AddConnectionString(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<CustomerDbContext>(options => options.UseSqlServer(connectionString));
        }
    }
}