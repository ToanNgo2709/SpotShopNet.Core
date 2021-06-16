using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Models.Entities
{
    [Table("UserInfo")]
    public class UserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("fullName")]
        public string FullName { get; set; }

        [Column("dob")]
        public DateTime Dob { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("country")]
        public string Country { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        public int UserRoleId { get; set; }

        [ForeignKey("userRoleId")]
        public UserRole UserRole;

        public ICollection<ProductReview> ProductReviews { get; set; }
        public ICollection<OrderInfo> OrderInfos { get; set; }
    }
}
