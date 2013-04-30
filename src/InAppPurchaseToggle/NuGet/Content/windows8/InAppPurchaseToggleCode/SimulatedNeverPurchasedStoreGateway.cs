using System;

namespace InAppPurchaseToggle
{
    /// <summary>
    /// Testing gateway that always pretends that a purchase has NOT been made
    /// </summary>
#if DEBUG
    [Obsolete("Be careful not to accidentally use this in the final app")]
#endif
    public class SimulatedNeverPurchasedStoreGateway : IStoreGateway
    {
        public bool IsPurchased(string inAppOfferName)
        {
            return false;
        }
    }
}