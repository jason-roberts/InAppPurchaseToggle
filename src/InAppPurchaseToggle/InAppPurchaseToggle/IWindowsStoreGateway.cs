namespace InAppPurchaseToggle
{
    public interface IWindowsStoreGateway
    {
        bool IsPurchased(string inAppOfferName);
    }
}