using InAppPurchaseToggle.WindowsStore;

namespace InAppPurchaseToggle
{
    public abstract class ToggleBase
    {
        public IWindowsStoreGateway WindowsStoreGateway { get; set; }

        protected ToggleBase()
        {
            WindowsStoreGateway = new RealWindowsStoreGateway();
        }

        public bool IsPurchased
        {
            get { return WindowsStoreGateway.LookupActiveStatus(new ToggleToInAppOfferNameMapper().Map(this)); }
         }
        }
    }

