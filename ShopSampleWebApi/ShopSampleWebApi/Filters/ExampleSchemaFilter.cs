using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using ShopSampleWebApi.Core.DataTransferObjects;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ShopSampleWebApi.Filters
{
    /// <summary>
    /// A schema filter to provide example values for Data Transfer Objects in Swagger documentation.
    /// </summary>
    public class ExampleSchemaFilter : ISchemaFilter
    {
        /// <summary>
        /// Applies example values for Data Transfer Objects.
        /// </summary>
        /// <param name="schema">The OpenApiSchema to modify.</param>
        /// <param name="context">The SchemaFilterContext providing context for the schema.</param>
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            // Check if the type is PagedListDto.
            if (context.Type.IsGenericType && context.Type.GetGenericTypeDefinition() == typeof(PagedListDto<>))
            {
                // Example values for PagedListDto properties.
                schema.Properties["pageNumber"].Example = new OpenApiInteger(1);
                schema.Properties["pageSize"].Example = new OpenApiInteger(10);
                schema.Properties["totalCount"].Example = new OpenApiInteger(100);
                schema.Properties["totalPages"].Example = new OpenApiInteger(10);
                schema.Properties["hasPrevious"].Example = new OpenApiBoolean(false);
                schema.Properties["hasNext"].Example = new OpenApiBoolean(true);

                // Example for `Items` (generic).
                var itemExample = new OpenApiArray
                {
                    new OpenApiObject
                    {
                        ["id"] = new OpenApiLong(1),
                        ["name"] = new OpenApiString("Sample Item")
                    }
                };

                schema.Properties["items"].Example = itemExample;
            }

            // Example for the specific model ProductDto.
            if (context.Type == typeof(ProductDto))
            {
                schema.Properties["id"].Example = new OpenApiLong(1);
                schema.Properties["name"].Example = new OpenApiString("Sample Product");
                schema.Properties["imgUri"].Example = new OpenApiString("https://example.com/image.jpg");
                schema.Properties["price"].Example = new OpenApiDouble(19.99);
                schema.Properties["description"].Example = new OpenApiString("A sample product used as an example.");
            }

            // Example for the specific model ProductDescriptionUpdateRequestDto.
            if (context.Type == typeof(ProductDescriptionUpdateRequestDto))
            {
                schema.Properties["description"].Example = new OpenApiString("A sample product used as an example.");
            }
        }
    }
}
