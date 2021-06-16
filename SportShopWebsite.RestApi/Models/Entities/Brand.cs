using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Models.Entities
{
    [Table("Brand")]
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("imagePath")]
        public string ImagePath { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
