namespace InAppPurchaseToggle
{
    public class NameNumberFormatter: IRepeatPurchaseToggleNameInstanceFormatter
    {
        public string Format(string storeInAppOfferBaseName, int repeatInstanceNumber)
        {
            return storeInAppOfferBaseName + repeatInstanceNumber;
        }
    }
}