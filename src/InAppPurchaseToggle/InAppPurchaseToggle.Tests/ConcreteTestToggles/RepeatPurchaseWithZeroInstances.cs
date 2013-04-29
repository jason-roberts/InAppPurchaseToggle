namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class RepeatPurchaseWithZeroInstances : RepeatPurchaseToggleBase
    {
        protected override int SetAvailableStoreInstances()
        {
            return 0;
        }
    }
}