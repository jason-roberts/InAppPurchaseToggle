namespace InAppPurchaseToggle
{
    public class NameUnderscoreNumberFormatter: IRepeatToggleInstanceNumberConcatinator
    {
        public string Combine(string toggleName, int instanceNumber)
        {
            return toggleName + "_" + instanceNumber;
        }
    }
}