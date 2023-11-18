using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BGDataLayer.DAL.Contexts
{
    public partial class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsEnabled { get; set; }
        public string Description { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; }
    }
}
