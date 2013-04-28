namespace InAppPurchaseToggle
{
    public interface IWindowsStoreGateway
    {

        // TODO: crap naming here
        bool LookupActiveStatus(string inAppOfferName);
    }
}