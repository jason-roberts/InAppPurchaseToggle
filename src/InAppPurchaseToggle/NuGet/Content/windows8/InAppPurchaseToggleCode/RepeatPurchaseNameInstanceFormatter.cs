namespace InAppPurchaseToggle
{
    public class RepeatPurchaseNameInstanceFormatter: IRepeatPurchaseToggleNameInstanceFormatter
    {
        public string Format(string storeInAppOfferBaseName, int repeatInstanceNumber)
        {
            return storeInAppOfferBaseName + repeatInstanceNumber;
        }
    }
}