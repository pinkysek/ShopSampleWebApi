using Microsoft.EntityFrameworkCore;

namespace ShopSampleWebApi.DataAccess.Factories
{
    /// <summary>
    /// Enum representing the type of database to be used.
    /// </summary>
    public enum DatabaseType
    {
        InMemory,
        Real
    }

    /// <summary>
    /// Factory class for creating instances of ApplicationDbContext.
    /// </summary>
    public static class DbContextFactory
    {
        /// <summary>
        /// Creates an instance of ApplicationDbContext based on the specified database type.
        /// </summary>
        /// <param name="type">The type of database to be used.</param>
        /// <param name="connectionString">The connection string for the real database. Optional for InMemory database.</param>
        /// <returns>An instance of ApplicationDbContext.</returns>
        public static ApplicationDbContext CreateDbContext(DatabaseType type, string? connectionString = null)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            if (type == DatabaseType.InMemory)
                optionsBuilder.UseInMemoryDatabase("TestDatabase");
            else if (type == DatabaseType.Real && connectionString != null)
                optionsBuilder.UseSqlServer(connectionString);

            var context = new ApplicationDbContext(optionsBuilder.Options);

            // Ensure the database is deleted and created anew for each test when using InMemory database.
            if (type == DatabaseType.InMemory)
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }

            return context;
        }
    }
}
