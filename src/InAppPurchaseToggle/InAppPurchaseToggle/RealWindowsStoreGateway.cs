using Windows.ApplicationModel.Store;

namespace InAppPurchaseToggle
{
    public class RealWindowsStoreGateway : IWindowsStoreGateway
    {
        public bool LookupActiveStatus(string inAppOfferName)
        {
            var licenseInformation = CurrentApp.LicenseInformation;

            return licenseInformation.ProductLicenses[inAppOfferName].IsActive;
        }
    }
}