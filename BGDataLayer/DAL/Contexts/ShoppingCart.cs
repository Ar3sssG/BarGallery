using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BGDataLayer.DAL.Contexts
{
    /// <summary>
    /// CHECK IS NEEDED?
    /// </summary>
    public class ShoppingCart
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public Guid UserGuid { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public bool IsEnabled { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
