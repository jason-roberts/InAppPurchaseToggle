using Windows.ApplicationModel.Store;

namespace InAppPurchaseToggle
{
    public class RealWindowsStoreGateway : IWindowsStoreGateway
    {
        public bool IsPurchased(string inAppOfferName)
        {
            var licenseInformation = CurrentApp.LicenseInformation;

            return licenseInformation.ProductLicenses[inAppOfferName].IsActive;
        }
    }
}