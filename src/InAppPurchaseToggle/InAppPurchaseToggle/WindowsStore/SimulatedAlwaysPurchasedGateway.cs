namespace InAppPurchaseToggle.WindowsStore
{
#if DEBUG

    public class SimulatedAlwaysPurchasedGateway : IWindowsStoreGateway
    {
        public bool LookupActiveStatus(string inAppOfferName)
        {
            return true;
        }
    }
#endif
}