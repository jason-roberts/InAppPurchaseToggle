using Windows.ApplicationModel.Store;

namespace InAppPurchaseToggle
{
    /// <summary>
    /// Live Windows Store gateway
    /// </summary>
    public class RealStoreGateway : IStoreGateway
    {
        public bool IsPurchased(string inAppOfferName)
        {
            var licenseInformation = CurrentApp.LicenseInformation;

            return licenseInformation.ProductLicenses[inAppOfferName].IsActive;
        }
    }
}