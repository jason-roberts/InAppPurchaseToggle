namespace InAppPurchaseToggle.WindowsStore
{
    public class SimulatedNeverPurchasedGateway : IWindowsStoreGateway
    {
        public bool LookupActiveStatus(string inAppOfferName)
        {
            return false;
        }
    }
}
