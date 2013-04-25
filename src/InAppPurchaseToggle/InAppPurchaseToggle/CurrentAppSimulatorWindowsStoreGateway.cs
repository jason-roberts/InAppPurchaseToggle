using Windows.ApplicationModel.Store;

namespace InAppPurchaseToggle
{
    public class CurrentAppSimulatorWindowsStoreGateway : IWindowsStoreGateway
    {
        public bool LookupActiveStatus(string inAppOfferName)
        {
            var licenseInformation = CurrentAppSimulator.LicenseInformation;

            return licenseInformation.ProductLicenses[inAppOfferName].IsActive;
        }
    }
}