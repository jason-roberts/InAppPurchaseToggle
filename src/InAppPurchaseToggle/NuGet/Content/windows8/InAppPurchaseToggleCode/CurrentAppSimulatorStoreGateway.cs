﻿using System;
using Windows.ApplicationModel.Store;

namespace InAppPurchaseToggle
{
    /// <summary>
    /// Testing gateway that uses the WinRT CurrentAppSimulator class to
    /// decide if a purchase has been made
    /// </summary>
#if DEBUG
    [Obsolete("Be careful not to accidentally use this in the final app")]
#endif
    public class CurrentAppSimulatorStoreGateway : IStoreGateway
    {
        public bool IsPurchased(string inAppOfferName)
        {
            var licenseInformation = CurrentAppSimulator.LicenseInformation;

            return licenseInformation.ProductLicenses[inAppOfferName].IsActive;
        }
    }
}