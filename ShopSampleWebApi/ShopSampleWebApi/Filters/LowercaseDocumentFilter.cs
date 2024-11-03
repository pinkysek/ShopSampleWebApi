using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ShopSampleWebApi.Filters
{
    /// <summary>
    /// This filter ensures that all paths in the Swagger document are converted to lowercase.
    /// </summary>
    public class LowercaseDocumentFilter : IDocumentFilter
    {
        /// <summary>
        /// Applies the filter to the Swagger document.
        /// Converts all paths in the Swagger document to lowercase.
        /// </summary>
        /// <param name="swaggerDoc">The Swagger document to modify.</param>
        /// <param name="context">The context for the document filter.</param>
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            // Convert all paths to lowercase.
            var paths = swaggerDoc.Paths.ToDictionary(
                entry => entry.Key.ToLowerInvariant(),
                entry => entry.Value
            );

            // Clear the existing paths and add the modified paths.
            swaggerDoc.Paths = new OpenApiPaths();
            foreach (var path in paths)
            {
                swaggerDoc.Paths.Add(path.Key, path.Value);
            }
        }
    }
}
