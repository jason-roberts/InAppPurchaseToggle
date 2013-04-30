namespace InAppPurchaseToggle
{
    /// <summary>
    /// Formats a final in app offer name by appending instance number to the base offer name
    /// </summary>
    public class NameNumberFormatter : IRepeatPurchaseToggleNameInstanceFormatter
    {
        public string Format(string storeInAppOfferBaseName, int repeatInstanceNumber)
        {
            return storeInAppOfferBaseName + repeatInstanceNumber;
        }
    }
}