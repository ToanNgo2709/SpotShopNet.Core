using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Models.Entities
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }


        public int OrderId { get; set; }
        [ForeignKey("orderId")]
        public OrderInfo OrderInfo { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("productId")]
        public Product Product { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("tempTotal")]
        public float TempTotal { get; set; }

    }
}
