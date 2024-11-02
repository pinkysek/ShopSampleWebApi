﻿namespace ShopSampleWebApi.DataAccess.Helpers
{
    /// <summary>  
    /// Represents a paginated list of items.  
    /// </summary>  
    /// <typeparam name="T">The type of items in the list.</typeparam>  
    public class PagedList<T>
    {
        /// <summary>  
        /// Gets or sets the items in the current page.  
        /// </summary>  
        public IEnumerable<T> Items { get; set; }

        /// <summary>  
        /// Gets or sets the current page number.  
        /// </summary>  
        public int PageNumber { get; set; }

        /// <summary>  
        /// Gets or sets the number of items per page.  
        /// </summary>  
        public int PageSize { get; set; }

        /// <summary>  
        /// Gets or sets the total number of items.  
        /// </summary>  
        public int TotalCount { get; set; }

        /// <summary>  
        /// Gets the total number of pages.  
        /// </summary>  
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);

        /// <summary>  
        /// Gets a value indicating whether there is a previous page.  
        /// </summary>  
        public bool HasPrevious => PageNumber > 1;

        /// <summary>  
        /// Gets a value indicating whether there is a next page.  
        /// </summary>  
        public bool HasNext => PageNumber < TotalPages;

        /// <summary>  
        /// Initializes a new instance of the <see cref="PagedList{T}"/> class.  
        /// </summary>  
        /// <param name="items">The items in the current page.</param>  
        /// <param name="count">The total number of items.</param>  
        /// <param name="pageNumber">The current page number.</param>  
        /// <param name="pageSize">The number of items per page.</param>  
        public PagedList(IEnumerable<T> items, int count, int pageNumber, int pageSize)
        {
            Items = items;
            TotalCount = count;
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
