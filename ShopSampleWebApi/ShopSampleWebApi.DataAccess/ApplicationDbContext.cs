using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using ShopSampleWebApi.DataAccess.Models.Base;
using ShopSampleWebApi.DataAccess.Models;
using Bogus;

namespace ShopSampleWebApi.DataAccess
{
    /// <summary>
    /// Represents the application's database context.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the Products DbSet.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Configures the model that was discovered by convention from the entity types
        /// exposed in DbSet properties on your derived context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Automatically set CreatedOn and UpdatedOn properties.
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType) && entityType.ClrType != typeof(BaseEntity))
                {
                    modelBuilder.Entity(entityType.ClrType)
                        .Property("CreatedOn")
                        .HasDefaultValueSql("GETDATE()");

                    modelBuilder.Entity(entityType.ClrType)
                        .Property("UpdatedOn")
                        .HasDefaultValue(null);
                }
            }

            // Seed data for Product entity (100 products).
            modelBuilder.Entity<Product>().HasData(GenerateProductsSeedData(100));
        }

        /// <summary>
        /// Saves all changes made in this context to the database.
        /// </summary>
        /// <returns>The number of state entries written to the database.</returns>
        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Added)
                    ((BaseEntity)entityEntry.Entity).CreatedOn = DateTime.Now;

                if (entityEntry.State == EntityState.Modified)
                    ((BaseEntity)entityEntry.Entity).UpdatedOn = DateTime.Now;
            }

            return base.SaveChanges();
        }

        /// <summary>
        /// Generates seed data for the Product entity.
        /// </summary>
        /// <param name="numberOfProducts">The number of products to generate.</param>
        /// <returns>A list of generated products.</returns>
        private List<Product> GenerateProductsSeedData(int numberOfProducts)
        {
            var faker = new Faker();
            var products = new List<Product>();

            for (int i = 1; i <= numberOfProducts; i++)
            {
                var product = new Product
                {
                    Id = i,
                    Name = faker.Commerce.ProductName(),
                    ImgUri = faker.Image.PicsumUrl(200, 200, true),  // Random image URL from Picsum.
                    Price = faker.Random.Decimal(1000, 50000),  // Generates a random price between 1000 and 50000.
                    Description = faker.Commerce.ProductDescription(),  // Random description.
                    CreatedOn = DateTime.Now
                };

                products.Add(product);
            }

            return products;
        }
    }
}
