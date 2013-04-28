namespace InAppPurchaseToggle
{
    public interface IWindowsStoreGateway
    {

        // TODO: crap naming here
        bool IsPurchased(string inAppOfferName);
    }
}