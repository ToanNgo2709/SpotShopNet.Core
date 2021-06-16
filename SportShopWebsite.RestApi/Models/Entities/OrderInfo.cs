using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Models.Entities
{
    [Table("OrderInfo")]
    public class OrderInfo
    {
        [Key]
        public int Id { get; set; }

        [Column("createDate")]
        public DateTime CreateDate { get; set; }

        [Column("totalPayment")]
        public float TotalPayment { get; set; }

        [Column("paymentMethod")]
        public string PaymentMethod { get; set; }

        public int UserInfoId { get; set; }
        [ForeignKey("UserInfoId")]
        public UserInfo UserInfo { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Paymade> Paymades { get; set; }
    }
}
