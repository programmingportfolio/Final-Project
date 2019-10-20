using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoftwareStore.Models.Abstract;
using SoftwareStore.Models.Products;

namespace SoftwareStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Software> Softwares { get; set; }

    }
    public class Software : IProduct
    {
        public bool isDownload;
        public bool isSubscription;
        public bool isDownSub;

        // change to list tuple of username and datetime
        public string UserName { get; set; }

        [Key]
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string ShortDescription { get; set; }

        // allow interactive content support with size limitations
        public string LongDescription { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string EasyUrl { get; set; }
        public string VideoUrl { get; set; }
        public string PictureUrl1 { get; set; }
        public string PictureUrl2 { get; set; }
        public string PictureUrl3 { get; set; }
        public string PictureUrl4 { get; set; }
        public string PictureUrl5 { get; set; }
        public string PictureUrl6 { get; set; }
        public string PictureUrl7 { get; set; }
        public string PictureUrl8 { get; set; }
    }
}
