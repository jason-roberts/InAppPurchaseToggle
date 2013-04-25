namespace InAppPurchaseToggle.WindowsStore
{
    public interface IWindowsStoreGateway
    {
        bool LookupActiveStatus(string inAppOfferName);
    }
}