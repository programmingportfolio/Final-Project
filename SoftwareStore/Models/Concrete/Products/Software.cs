using SoftwareStore.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Models.Concrete.Products
{
    public class Software : Product
    {
        public bool isDownload;
        public bool isSubscription;
        public bool isDownSub;
    }
}
