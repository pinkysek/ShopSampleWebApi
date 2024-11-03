using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ShopSampleWebApi.DataAccess
{
    /// <summary>
    /// Provides methods to initialize the database.
    /// </summary>
    public static class DatabaseInitializer
    {
        /// <summary>
        /// Initializes the database by ensuring it is created if it is an in-memory database.
        /// </summary>
        /// <param name="serviceProvider">The service provider to create a scope and get the database context.</param>
        public static void InitializeDatabase(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            if (context.Database.IsInMemory())
                context.Database.EnsureCreated();
        }
    }
}
