using Windows.ApplicationModel.Store;

namespace InAppPurchaseToggle
{
    public class RealStoreGateway : IStoreGateway
    {
        public bool IsPurchased(string inAppOfferName)
        {
            var licenseInformation = CurrentApp.LicenseInformation;

            return licenseInformation.ProductLicenses[inAppOfferName].IsActive;
        }
    }
}