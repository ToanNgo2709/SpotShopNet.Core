using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Models.Entities
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("imagePath")]
        public string ImagePath { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        public int SportId { get; set; }
        [ForeignKey("sportId")]
        public Sport Sport { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
