using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Models.Entities
{
    [Table("PayMade")]
    public class Paymade
    {
        [Key]
        public int Id { get; set; }

        [Column("cardNo")]
        public string CardNo { get; set; }

        [Column("company")]
        public string Company { get; set; }

        [Column("validDate")]
        public string ValidDate { get; set; }

        [Column("expiredDate")]
        public string ExpiredDate { get; set; }

        [Column("holderName")]
        public string HolderName { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        public int OrderInfoId { get; set; }
        [ForeignKey("orderInfoId")]
        public OrderInfo OrderInfo { get; set; }
    }
}
