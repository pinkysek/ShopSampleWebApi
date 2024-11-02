using ShopSampleWebApi.DataAccess.Helpers;

namespace ShopSampleWebApi.DataAccess.Interfaces.Base
{
    /// <summary>
    /// Interface for basic repository operations.
    /// </summary>
    /// <typeparam name="T">The type of the entity.</typeparam>
    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// Gets an entity by identifier.
        /// </summary>
        /// <param name="id">The identifier of the entity.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the entity.</returns>
        Task<T> GetByIdAsync(long id);

        /// <summary>
        /// Gets all entities.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a collection of entities.</returns>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// Gets a paginated list of all entities.
        /// </summary>
        /// <param name="pageNumber">The page number to retrieve.</param>
        /// <param name="pageSize">The number of entities per page.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a paginated list of entities.</returns>
        Task<PagedList<T>> GetAllAsync(int pageNumber, int pageSize);

        /// <summary>
        /// Adds a new entity.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task AddAsync(T entity);

        /// <summary>
        /// Updates an existing entity.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task UpdateAsync(T entity);

        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task DeleteAsync(T entity);
    }
}
