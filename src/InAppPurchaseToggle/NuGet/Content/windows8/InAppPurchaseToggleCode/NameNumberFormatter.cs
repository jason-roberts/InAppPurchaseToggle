namespace InAppPurchaseToggle
{
    public class NameNumberFormatter: IRepeatToggleInstanceNumberConcatinator
    {
        public string Combine(string toggleName, int instanceNumber)
        {
            return toggleName + instanceNumber;
        }
    }
}