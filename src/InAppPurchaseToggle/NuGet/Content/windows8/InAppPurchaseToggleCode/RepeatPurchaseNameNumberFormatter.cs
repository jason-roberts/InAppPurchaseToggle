namespace InAppPurchaseToggle
{
    public class RepeatPurchaseNameNumberFormatter: IRepeatPurchaseToggleNameInstanceFormatter
    {
        public string Format(string toggleName, int repeatInstanceNumber)
        {
            return toggleName + repeatInstanceNumber;
        }
    }
}