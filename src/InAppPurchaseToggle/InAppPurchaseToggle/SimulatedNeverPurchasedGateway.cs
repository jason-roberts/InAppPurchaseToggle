﻿using System;

namespace InAppPurchaseToggle
{
#if DEBUG
    [Obsolete("Be careful not to accidentally use this in the final app")]
#endif
    public class SimulatedNeverPurchasedGateway : IWindowsStoreGateway
    {
        public bool IsPurchased(string inAppOfferName)
        {
            return false;
        }
    }
}
