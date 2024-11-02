using AutoMapper;
using ShopSampleWebApi.Core.DataTransferObjects;
using ShopSampleWebApi.Core.Interfaces.Base;
using ShopSampleWebApi.DataAccess.Interfaces.Base;

namespace ShopSampleWebApi.Core.Services.Base
{
    public class BaseService<T, TDto> : IBaseService<T, TDto> where T : class
    {
        protected readonly IBaseRepository<T> _repository;
        protected readonly IMapper _mapper;

        public BaseService(IBaseRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task<TDto> GetByIdAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity == null ? default : _mapper.Map<TDto>(entity);
        }

        public virtual async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public virtual async Task<PagedListDto<TDto>> GetAllAsync(int pageNumber, int pageSize)
        {
            var pagedList = await _repository.GetAllAsync(pageNumber, pageSize);
            var dtoItems = _mapper.Map<IEnumerable<TDto>>(pagedList.Items).ToList();

            return new PagedListDto<TDto>(
                dtoItems,
                pagedList.TotalCount,
                pagedList.PageNumber,
                pagedList.PageSize
            );
        }

        public virtual async Task<bool> AddAsync(TDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            return await _repository.AddAsync(entity);
        }

        public virtual async Task<bool> UpdateAsync(long id, TDto dto)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) 
                return false;

            _mapper.Map(dto, entity);
            return await _repository.UpdateAsync(entity);
        }

        public virtual async Task<bool> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) 
                return false;

            return await _repository.DeleteAsync(entity);
        }
    }
}
