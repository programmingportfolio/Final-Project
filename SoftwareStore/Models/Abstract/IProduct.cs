using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Models.Abstract
{
    interface IProduct
    {
        string UserName { get; set; }

        string ProductName { get; set; }
        string ProductCategory { get; set; }
        string ShortDescription { get; set; }
        string LongDescription { get; set; }
        double Price { get; set; }
        int Quantity { get; set; }
        string EasyUrl { get; set; }
        string VideoUrl { get; set; }
        string PictureUrl1 { get; set; }
        string PictureUrl2 { get; set; }
        string PictureUrl3 { get; set; }
        string PictureUrl4 { get; set; }
        string PictureUrl5 { get; set; }
        string PictureUrl6 { get; set; }
        string PictureUrl7 { get; set; }
        string PictureUrl8 { get; set; }
    }
}
