namespace InAppPurchaseToggle
{
    public class NameUnderscoreNumberFormatter: IRepeatPurchaseToggleNameInstanceFormatter
    {
        public string Format(string toggleName, int instanceNumber)
        {
            return toggleName + "_" + instanceNumber;
        }
    }
}