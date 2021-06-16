using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Models.Entities
{
    [Table("ProductImage")]
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }

        [Column("priority")]
        public int Priority { get; set; }

        [Column("imagePath")]
        public string ImagePath { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("productId")]
        public Product Product { get; set; }
    }
}
