namespace InAppPurchaseToggle
{
    public interface IWindowsStoreGateway
    {
        bool LookupActiveStatus(string inAppOfferName);
    }
}