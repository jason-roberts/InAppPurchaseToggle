namespace InAppPurchaseToggle
{
    public interface IStoreGateway
    {
        bool IsPurchased(string inAppOfferName);
    }
}