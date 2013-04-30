namespace InAppPurchaseToggle
{
    /// <summary>
    /// Formats a final in app offer name by appending an underscore then instance number to the base offer name
    /// </summary>
    public class NameUnderscoreNumberFormatter : IRepeatPurchaseToggleNameInstanceFormatter
    {
        public string Format(string storeInAppOfferBaseName, int repeatInstanceNumber)
        {
            return storeInAppOfferBaseName + "_" + repeatInstanceNumber;
        }
    }
}