using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Models
{
    public class Software
    {
        public bool isDownload;
        public bool isSubscription;
        public bool isDownSub;
        public string UserName { get; set; }

        public string productName { get; set; }
        public string productCategory { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        decimal price { get; set; }
        public int quantity { get; set; }
        public string easyUrl { get; set; }
        public string videoUrl { get; set; }
        public string pictureUrl1 { get; set; }
        public string pictureUrl2 { get; set; }
        public string pictureUrl3 { get; set; }
        public string pictureUrl4 { get; set; }
        public string pictureUrl5 { get; set; }
        public string pictureUrl6 { get; set; }
        public string pictureUrl7 { get; set; }
        public string pictureUrl8 { get; set; }
    }
}
