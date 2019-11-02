using SoftwareStore.Models.ViewModels.Abstract;

namespace SoftwareStore.Models.ViewModels.Concrete
{
    public class SoftwareViewModel : ProductViewModel
    {
        public bool isDownload;
        public bool isSubscription;
        public bool isDownSub;
    }
}
