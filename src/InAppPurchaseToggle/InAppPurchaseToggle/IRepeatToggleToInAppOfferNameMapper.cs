namespace InAppPurchaseToggle
{
    public interface IRepeatPurchaseToggleNameInstanceFormatter
    {
        string Format(string storeInAppOfferBaseName, int repeatInstanceNumber);
    }
}