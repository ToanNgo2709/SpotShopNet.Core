using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Models.Entities
{
    [Table("Sport")]
    public class Sport
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("imagePath")]
        public string ImagePath { get; set; }

        [Column("active")]
        public bool active { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
