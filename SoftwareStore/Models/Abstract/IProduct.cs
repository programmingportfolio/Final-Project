using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Models.Abstract
{
    interface IProduct
    {
         int managerId { get; set; }

         string productName { get; set; }
         string productCategory { get; set; }
         string shortDescription { get; set; }
         string longDescription { get; set; }
         decimal price { get; set; }
         int quantity { get; set; }
         string easyUrl { get; set; }
         string videoUrl { get; set; }
         string pictureUrl1 { get; set; }
         string pictureUrl2 { get; set; }
         string pictureUrl3 { get; set; }
         string pictureUrl4 { get; set; }
         string pictureUrl5 { get; set; }
         string pictureUrl6 { get; set; }
         string pictureUrl7 { get; set; }
         string pictureUrl8 { get; set; }

        //public List<string> pictureUrls = new List<string>();
        //public static int pictureCount { get; set; }
        //public bool hasPictures { get; set; }
        bool hasVideo { get; set; }
        //public int productCount { get; set; }





        string CreateEasyURL(string productCategory, string productName);

        void OnChange();

        string ToString();

    }
}
