﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Models.Entities
{
    [Table("ProductReview")]
    public class ProductReview
    {
        [Key]
        public int Id { get; set; }

        public int UserInfoId { get; set; }
        [ForeignKey("userInfoId")]
        public UserInfo UserInfo { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("productId")]
        public Product Product { get; set; }

        [Column("content")]
        public string Content { get; set; }

        [Column("createDate")]
        public DateTime CreateDate { get; set; }

        [Column("active")]
        public bool Active { get; set; }

    }
}
