﻿namespace InAppPurchaseToggle
{
    public class SimulatedNeverPurchasedGateway : IWindowsStoreGateway
    {
        public bool LookupActiveStatus(string inAppOfferName)
        {
            return false;
        }
    }
}
