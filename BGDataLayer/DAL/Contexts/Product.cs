using System.ComponentModel.DataAnnotations;

namespace BGDataLayer.DAL.Contexts
{
    public partial class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        [Required]
        public bool InStock { get; set; }
        [Required]
        public string Article { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [Required]
        public int SubCategoryID { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public virtual Category Category { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}
