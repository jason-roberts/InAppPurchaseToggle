using System;

namespace InAppPurchaseToggle
{
    /// <summary>
    /// Testing gateway that always pretends that a purchase has been made
    /// </summary>
#if DEBUG
    [Obsolete("Be careful not to accidentally use this in the final app")]
#endif
    public class SimulatedAlwaysPurchasedStoreGateway : IStoreGateway
    {
        public bool IsPurchased(string inAppOfferName)
        {
            return true;
        }
    }
}