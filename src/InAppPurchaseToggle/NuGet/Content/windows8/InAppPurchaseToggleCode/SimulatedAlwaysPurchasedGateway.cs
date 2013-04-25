namespace InAppPurchaseToggle
{
    public class SimulatedAlwaysPurchasedGateway : IWindowsStoreGateway
    {
        public bool LookupActiveStatus(string inAppOfferName)
        {
            return true;
        }
    }
}