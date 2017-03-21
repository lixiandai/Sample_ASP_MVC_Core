using Sample.Core.Recipes.Data;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.Core.Recipes.Application
{
    public static class Startup
    {
        public static void AddMediatRForRecipes(this IServiceCollection services)
        {
            //Get the Type of current instance.
            services.AddMediatR();
        }

        public static void AddRecipesConnectionString(this IServiceCollection services, string connectionString)
        {
            services.AddConnectionString(connectionString);
        }
    }
}