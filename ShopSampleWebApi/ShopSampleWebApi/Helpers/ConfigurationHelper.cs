using Microsoft.Extensions.Options;
using ShopSampleWebApi.Configurations;

namespace ShopSampleWebApi.Helpers
{
    public static class ConfigurationHelper
    {
        /// <summary>
        /// Retrieves the database settings from the appsettings.json configuration file.
        /// </summary>
        /// <returns>An instance of <see cref="DatabaseSettings"/> containing the database configuration.</returns>
        public static DatabaseSettings GetDatabaseSettings()
        {
            // Get the current environment, default is "Development".
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development";

            // Load configuration from appsettings.json and environment-specific appsettings file.
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true) // Override with environment-specific settings.
                .Build();

            // Configure DatabaseSettings as a service and load values.
            var serviceCollection = new ServiceCollection();
            serviceCollection.Configure<DatabaseSettings>(configuration.GetSection("DatabaseSettings"));

            var serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider.GetRequiredService<IOptions<DatabaseSettings>>().Value;
        }
    }
}
