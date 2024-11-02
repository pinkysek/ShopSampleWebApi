namespace ShopSampleWebApi.Configurations
{
    /// <summary>
    /// Represents the settings required for database configuration.
    /// </summary>
    public class DatabaseSettings
    {
        /// <summary>
        /// Gets or sets the type of the database.
        /// </summary>
        public string? DatabaseType { get; set; }

        /// <summary>
        /// Gets or sets the connection string for the real database.
        /// </summary>
        public string? RealDatabaseConnectionString { get; set; }

        /// <summary>
        /// Returns a string representation of the database settings.
        /// </summary>
        /// <returns>A string that represents the current database settings.</returns>
        public override string ToString()
        {
            return $"DatabaseType: {DatabaseType}, RealDatabaseConnectionString: {RealDatabaseConnectionString}";
        }
    }
}
