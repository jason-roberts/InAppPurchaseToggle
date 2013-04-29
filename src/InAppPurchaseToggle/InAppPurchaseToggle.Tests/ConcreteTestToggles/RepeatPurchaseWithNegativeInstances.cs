namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class RepeatPurchaseWithNegativeInstances : RepeatPurchaseToggleBase
    {
        protected override int SetAvailableStoreInstances()
        {
            return -1;
        }
    }
}