using System.ComponentModel.DataAnnotations;

namespace BGDataLayer.DAL.Contexts
{
    public class SubCategory
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryID { get; set; }
        public string Description { get; set; }
        [Required]
        public bool IsEnabled { get; set; }
        public virtual Category Category { get; set; }
    }
}
