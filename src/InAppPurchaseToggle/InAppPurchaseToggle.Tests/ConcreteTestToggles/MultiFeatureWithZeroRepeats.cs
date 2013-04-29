namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class MultiFeatureWithZeroRepeats : RepeatPurchaseToggleBase
    {
        protected override int SetAvailableStoreInstances()
        {
            return 0;
        }
    }
}