using Microsoft.EntityFrameworkCore;
using SportShopWebsite.RestApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Models.Context
{
    public class SportDbContext : DbContext
    {
        private static readonly SportDbContext _context;
        private SportDbContext() { }

        public static SportDbContext GetInstance
        {
            get
            {
                if(_context != null)
                {
                    return new SportDbContext();
                }
                return _context;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Date Source:.;Initial Catalog=sport_website; Intergrated Security=SSPI;User Id =toan;password=Toan.123";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderInfo> OrderInfos { get; set; }
        public DbSet<Paymade> Paymades { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
