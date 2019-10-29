using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SoftwareStore.Data;
using SoftwareStore.Models.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(ApplicationDbContext context, IdentityUserContext<ApplicationUser> userManager)
        {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var existingSoftware = context.Softwares.ToList();

            var newSoftware = new Software[]
           {
               new Software
               {
                                isSubscription = false,
                                isDownload = false,
                                isDownSub = true,
                                UserName         = "Username",
                                ProductName      = "Product Name",
                                ProductCategory  = "Product Category",
                                ShortDescription = "Short Description",
                                LongDescription  = "Long Description",
                                Price            = 100.00,
                                Quantity         = 1,
                                EasyUrl          = "Easy Url",
                                VideoUrl         = "Video Url",
                                PictureUrl1      = "Picture Url1",
                                PictureUrl2      = "Picture Url2",
                                PictureUrl3      = "Picture Url3",
                                PictureUrl4      = "Picture Url4",
                                PictureUrl5      = "Picture Url5",
                                PictureUrl6      = "Picture Url6",
                                PictureUrl7      = "Picture Url7",
                                PictureUrl8      = "Picture Url8",
                                }
           };                                    
                                           

            // Look for existing matches

            var softwareDiff = from software in newSoftware
                       where !existingSoftware.Any(s => s.EasyUrl == software.EasyUrl)
                       select software;

           List<Software> softwareDiffList = softwareDiff.Select(s => new Software {

               isSubscription = s.isSubscription,
               isDownload = s.isDownload,
               isDownSub = s.isDownSub,
               UserName = s.UserName,
               ProductName = s.ProductName,
               ProductCategory = s.ProductCategory,
               ShortDescription = s.ShortDescription,
               LongDescription = s.LongDescription,
               Price = s.Price,
               Quantity = s.Quantity,
               EasyUrl = s.EasyUrl,
               VideoUrl = s.VideoUrl,
               PictureUrl1 = s.PictureUrl1,
               PictureUrl2 = s.PictureUrl2,
               PictureUrl3 = s.PictureUrl3,
               PictureUrl4 = s.PictureUrl4,
               PictureUrl5 = s.PictureUrl5,
               PictureUrl6 = s.PictureUrl6,
               PictureUrl7 = s.PictureUrl7,
               PictureUrl8 = s.PictureUrl8,

           }).ToList();

            foreach (Software software in softwareDiffList)
            {
                context.Softwares.Add(software);
            }

            //var existingSoftware = context.Softwares.ToList();

            var founder = new ApplicationUser
            {
                Email = "luke@luke.com",

            };


            // Look for existing matches

            var founderDiff = from software in newSoftware
                       where !existingSoftware.Any(s => s.EasyUrl == software.EasyUrl)
                       select software;

            List<ApplicationUser> founderDiffList = founderDiff.Select(s => new ApplicationUser
            {


            }).ToList();

            foreach (ApplicationUser user in founderDiffList)
            {
                userManager.Add(user);
            }

            context.SaveChanges();
        }
    }
}
