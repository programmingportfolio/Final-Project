using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Models.Products
{
    class Software : Abstract.Product
    {

        bool isDownload;
        bool isSubscription;
        bool isDownSub;

        internal static bool IsSoftware(object comparison)
        {
            if (comparison is Software)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}