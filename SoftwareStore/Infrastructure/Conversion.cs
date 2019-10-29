using SoftwareStore.Data;
using SoftwareStore.Models.Abstract;
using SoftwareStore.Models.Concrete.Products;
using SoftwareStore.Models.ViewModels.Concrete;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Infrastructure
{
    static class Conversion
    {
        public static SoftwareViewModel ConvertToViewModel(Software s)
        {
            var software = new SoftwareViewModel
            {
                isSubscription = s.isSubscription,
                isDownload = s.isDownload,
                isDownSub = s.isDownSub,
                ProductName = s.ProductName,
                ProductCategory = s.ProductCategory,
                ShortDescription = s.ShortDescription,
                LongDescription = s.LongDescription,
                Price = s.Price,
                VideoUrl = s.VideoUrl,
                PictureUrl1 = s.PictureUrl1,
                PictureUrl2 = s.PictureUrl2,
                PictureUrl3 = s.PictureUrl3,
                PictureUrl4 = s.PictureUrl4,
                PictureUrl5 = s.PictureUrl5,
                PictureUrl6 = s.PictureUrl6,
                PictureUrl7 = s.PictureUrl7,
                PictureUrl8 = s.PictureUrl8,
            };
            return software;
        }
        
        


        public static void ConvertToViewModel<T>(T _)
        {
            Console.WriteLine("...");
        }
    }
}
