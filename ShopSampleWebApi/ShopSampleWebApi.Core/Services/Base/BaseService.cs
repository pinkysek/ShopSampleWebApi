using AutoMapper;
using Microsoft.Extensions.Logging;
using ShopSampleWebApi.Core.DataTransferObjects;
using ShopSampleWebApi.Core.Interfaces.Base;
using ShopSampleWebApi.DataAccess.Interfaces.Base;

namespace ShopSampleWebApi.Core.Services.Base
{
    public class BaseService<T, TDto> : IBaseService<T, TDto> where T : class
    {
        protected readonly IBaseRepository<T> _repository;
        protected readonly IMapper _mapper;
        protected readonly ILogger<BaseService<T, TDto>> _logger;

        public BaseService(IBaseRepository<T> repository, IMapper mapper, ILogger<BaseService<T, TDto>> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public virtual async Task<TDto?> GetByIdAsync(long id)
        {
            _logger.LogInformation($"Getting entity of type {typeof(T).Name} with ID {id}.");

            try
            {
                var entity = await _repository.GetByIdAsync(id);
                if (entity == null)
                {
                    _logger.LogWarning($"Entity with ID {id} is not found.");
                    return default;
                }
                return _mapper.Map<TDto>(entity);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"An error occurred while getting the product with ID {id}.");
                throw;
            }
        }

        public virtual async Task<IEnumerable<TDto>> GetAllAsync()
        {
            _logger.LogInformation($"Starting GetAllAsync for entity type {typeof(T).Name}.");

            try
            {
                var entities = await _repository.GetAllAsync();
                _logger.LogInformation($"Successfully retrieved {entities.Count()} records of type {typeof(T).Name}.");
                return _mapper.Map<IEnumerable<TDto>>(entities);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"An error occurred while retrieving records of type {typeof(T).Name}.");
                throw; 
            }
        }

        public virtual async Task<PagedListDto<TDto>> GetAllAsync(int pageNumber, int pageSize)
        {
            _logger.LogInformation($"Starting GetAllAsync with pagination for entity type {typeof(T).Name}. Page number: {pageNumber}, Page size: {pageSize}.");

            try
            {
                var pagedList = await _repository.GetAllAsync(pageNumber, pageSize);
                var dtoItems = _mapper.Map<IEnumerable<TDto>>(pagedList.Items).ToList();

                _logger.LogInformation($"Successfully retrieved page {pageNumber} with {dtoItems.Count} records of type {typeof(T).Name}.");

                return new PagedListDto<TDto>(
                    dtoItems,
                    pagedList.TotalCount,
                    pagedList.PageNumber,
                    pagedList.PageSize
                );
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"An error occurred while retrieving paginated records of type {typeof(T).Name} for page {pageNumber} with page size {pageSize}.");
                throw; 
            }
        }

        public virtual async Task<bool> AddAsync(TDto dto)
        {
            _logger.LogInformation($"Starting AddAsync for entity type {typeof(T).Name}.");

            try
            {
                var entity = _mapper.Map<T>(dto);

                var result = await _repository.AddAsync(entity);
                if (result)
                    _logger.LogInformation($"Successfully added entity of type {typeof(T).Name}.");
                else
                    _logger.LogWarning($"Failed to add entity of type {typeof(T).Name}.");
                
                return result;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"An error occurred while adding an entity of type {typeof(T).Name}.");
                throw;
            }
        }

        public virtual async Task<bool> UpdateAsync(long id, TDto dto)
        {
            _logger.LogInformation($"Starting UpdateAsync for entity type {typeof(T).Name} with ID {id}.");

            try
            {
                var entity = await _repository.GetByIdAsync(id);
                if (entity == null)
                {
                    _logger.LogWarning($"Entity of type {typeof(T).Name} with ID {id} is not found.");
                    return false;
                }

                _mapper.Map(dto, entity);

                var result = await _repository.UpdateAsync(entity);
                if (result)
                    _logger.LogInformation($"Successfully updated entity of type {typeof(T).Name} with ID {id}.");
                else
                    _logger.LogWarning($"Failed to update entity of type {typeof(T).Name} with ID {id}.");

                return result;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"An error occurred while updating entity of type {typeof(T).Name} with ID {id}.");
                throw;
            }
        }

        public virtual async Task<bool> DeleteAsync(long id)
        {
            _logger.LogInformation($"Starting DeleteAsync for entity type {typeof(T)} with ID {id}.");

            try
            {
                var entity = await _repository.GetByIdAsync(id);
                if (entity == null)
                {
                    _logger.LogWarning($"Entity of type {typeof(T).Name} with ID {id} is not found.");
                    return false;
                }

                var result = await _repository.DeleteAsync(entity);
                if (result)
                    _logger.LogInformation($"Successfully deleted entity of type {typeof(T).Name} with ID {id}.");
                else
                    _logger.LogWarning($"Failed to delete entity of type {typeof(T).Name} with ID {id}.");

                return result;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"An error occurred while deleting entity of type {typeof(T).Name} with ID {id}.");
                throw;
            }
        }
    }
}
