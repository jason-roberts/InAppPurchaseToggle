using System;
using Windows.ApplicationModel.Store;

namespace InAppPurchaseToggle
{
#if DEBUG
    [Obsolete("Be careful not to accidentally use this in the final app")]
#endif
    public class CurrentAppSimulatorWindowsStoreGateway : IWindowsStoreGateway
    {
        public bool LookupActiveStatus(string inAppOfferName)
        {
            var licenseInformation = CurrentAppSimulator.LicenseInformation;

            return licenseInformation.ProductLicenses[inAppOfferName].IsActive;
        }
    }
}