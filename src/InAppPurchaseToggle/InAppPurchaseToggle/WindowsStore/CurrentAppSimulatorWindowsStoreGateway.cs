using Windows.ApplicationModel.Store;

namespace InAppPurchaseToggle.WindowsStore
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