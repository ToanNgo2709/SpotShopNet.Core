using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Models.Entities
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("content")]
        public string Content { get; set; }

        [Column("active")]
        public bool Active { get; set; }
    }
}
