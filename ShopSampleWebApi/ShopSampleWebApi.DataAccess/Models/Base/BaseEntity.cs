using System.ComponentModel.DataAnnotations;

namespace ShopSampleWebApi.DataAccess.Models.Base
{
    // BaseEntity is an abstract class that serves as a base for other entities.
    // It includes common properties like Id, CreatedOn, UpdatedOn, and DeletedOn.
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }  // Primary key.

        public DateTime CreatedOn { get; set; }  // Record creation date.

        public DateTime? UpdatedOn { get; set; }  // Last update date (optional).

        public DateTime? DeletedOn { get; set; }  // Deletion date (optional).
    }
}
