namespace InAppPurchaseToggle
{
    public class NameUnderscoreNumberFormatter: IRepeatPurchaseToggleNameInstanceFormatter
    {
        public string Format(string storeInAppOfferBaseName, int repeatInstanceNumber)
        {
            return storeInAppOfferBaseName + "_" + repeatInstanceNumber;
        }
    }
}