using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Models.Entities
{
    [Table("Feedback")]
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [Column("sender")]
        public string Sender { get; set; }

        [Column("content")]
        public string Content { get; set; }

        [Column("active")]
        public bool Active { get; set; }
    }
}
