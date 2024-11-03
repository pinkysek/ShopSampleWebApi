using ShopSampleWebApi.Core.DataTransferObjects;

namespace ShopSampleWebApi.Core.Interfaces.Base
{
    /// <summary>
    /// Interface for base service operations.
    /// </summary>
    /// <typeparam name="T">The type of the entity.</typeparam>
    /// <typeparam name="TDto">The type of the data transfer object.</typeparam>
    public interface IBaseService<T, TDto>
    {
        /// <summary>
        /// Gets an entity by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the entity.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the DTO of the entity.</returns>
        Task<TDto?> GetByIdAsync(long id);

        /// <summary>
        /// Gets all entities.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a collection of DTOs of the entities.</returns>
        Task<IEnumerable<TDto>> GetAllAsync();

        /// <summary>
        /// Gets a paginated list of entities.
        /// </summary>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="pageSize">The number of items per page.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a paginated list DTO of the entities.</returns>
        Task<PagedListDto<TDto>> GetAllAsync(int pageNumber, int pageSize);

        /// <summary>
        /// Adds a new entity.
        /// </summary>
        /// <param name="dto">The DTO of the entity to add.</param>
        /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
        Task<bool> AddAsync(TDto dto);

        /// <summary>
        /// Updates an existing entity.
        /// </summary>
        /// <param name="id">The identifier of the entity to update.</param>
        /// <param name="dto">The DTO of the entity to update.</param>
        /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
        Task<bool> UpdateAsync(long id, TDto dto);

        /// <summary>
        /// Deletes an entity by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the entity to delete.</param>
        /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
        Task<bool> DeleteAsync(long id);
    }
}
