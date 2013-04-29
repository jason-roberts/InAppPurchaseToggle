namespace InAppPurchaseToggle
{
    public class NameNumberFormatter: IRepeatPurchaseToggleNameInstanceFormatter
    {
        public string Format(string toggleName, int instanceNumber)
        {
            return toggleName + instanceNumber;
        }
    }
}