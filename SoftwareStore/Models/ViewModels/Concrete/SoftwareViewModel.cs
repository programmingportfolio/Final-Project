using SoftwareStore.Models.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Models.ViewModels.Concrete
{
    public class SoftwareViewModel : ProductViewModel
    {
        public bool isDownload;
        public bool isSubscription;
        public bool isDownSub;
    }
}
