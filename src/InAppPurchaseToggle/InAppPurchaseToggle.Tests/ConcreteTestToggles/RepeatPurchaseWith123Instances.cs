namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class RepeatPurchaseWith123Instances : RepeatPurchaseToggleBase
    {
        protected override int SetAvailableStoreInstances()
        {
            return 123;
        }
    }
}