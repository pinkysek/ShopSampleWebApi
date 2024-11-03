using ShopSampleWebApi.DataAccess.Helpers;
using Swashbuckle.AspNetCore.Annotations;

namespace ShopSampleWebApi.Core.DataTransferObjects
{
    /// <summary>
    /// Represents a paginated list of items for data transfer.
    /// </summary>
    /// <typeparam name="T">The type of items in the list.</typeparam>
    [SwaggerSchema(Description = "Represents a paginated list of items for data transfer.")]
    public class PagedListDto<T>
    {
        /// <summary>
        /// Gets or sets the items in the current page.
        /// </summary>
        [SwaggerSchema(Description = "The items in the current page.")]
        public IEnumerable<T> Items { get; set; }

        /// <summary>
        /// Gets the current page number.
        /// </summary>
        [SwaggerSchema(Description = "The current page number.")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets the number of items per page.
        /// </summary>
        [SwaggerSchema(Description = "The number of items per page.")]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets the total number of items.
        /// </summary>
        [SwaggerSchema(Description = "The total number of items.")]
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets the total number of pages.
        /// </summary>
        [SwaggerSchema(Description = "The total number of pages.")]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets a value indicating whether there is a previous page.
        /// </summary>
        [SwaggerSchema(Description = "Indicates whether there is a previous page.")]
        public bool HasPrevious { get; set; }

        /// <summary>
        /// Gets a value indicating whether there is a next page.
        /// </summary>
        [SwaggerSchema(Description = "Indicates whether there is a next page.")]
        public bool HasNext { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedListDto{T}"/> class.
        /// </summary>
        /// <param name="items">The items in the current page.</param>
        /// <param name="count">The total number of items.</param>
        /// <param name="pageNumber">The current page number.</param>
        /// <param name="pageSize">The number of items per page.</param>
        public PagedListDto(IEnumerable<T> items, int count, int pageNumber, int pageSize)
        {
            Items = items;
            TotalCount = count;
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling((double)count / pageSize);
            HasPrevious = PageNumber > 1;
            HasNext = PageNumber < TotalPages;
        }

        /// <summary>
        /// Converts a <see cref="PagedList{T}"/> to a <see cref="PagedListDto{T}"/>.
        /// </summary>
        /// <param name="pagedList">The PagedList to convert.</param>
        /// <returns>A new PagedListDto containing the data from the PagedList.</returns>
        public static PagedListDto<T> FromPagedList(PagedList<T> pagedList)
        {
            return new PagedListDto<T>(
                pagedList.Items,
                pagedList.TotalCount,
                pagedList.PageNumber,
                pagedList.PageSize
            );
        }
    }
}
