namespace InAppPurchaseToggle.WindowsStore
{
#if DEBUG
    public class SimulatedNeverPurchasedGateway : IWindowsStoreGateway
    {
        public bool LookupActiveStatus(string inAppOfferName)
        {
            return false;
        }
    }
#endif
}
