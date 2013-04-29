namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class MultiFeatureWithNegativeRepeats : RepeatPurchaseToggleBase
    {
        protected override int SetAvailableStoreInstances()
        {
            return -1;
        }
    }
}