using System.ComponentModel.DataAnnotations;

namespace BGDataLayer.DAL.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        [Required]
        public int CreatedById { get; set; }
        public int? LastModifiedById { get; set; }
    }
}
