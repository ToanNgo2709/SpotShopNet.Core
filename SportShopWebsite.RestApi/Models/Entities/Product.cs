using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Models.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Column("productName")]
        public string ProductName { get; set; }

        [Column("price")]
        public double Price { get; set; }

        [Column("salePrice")]
        public double SalePrice { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        [Column("productInfo")]
        public string ProductInfo { get; set; }

        [Column("additionInfo")]
        public string AdditionInfo { get; set; }

        [Column("attribute")]
        public string Attribute { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("categoryId")]
        public Category Category { get; set; }

        public int BrandId { get; set; }
        [ForeignKey("brandId")]
        public Brand Brand { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductReview> ProductReviews { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
