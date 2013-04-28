namespace InAppPurchaseToggle
{
    public interface IRepeatToggleInstanceNumberConcatinator
    {
        string Combine(string toggleName, int instanceNumber);
    }
}