namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class RepeatPurchaseWithNullFormatter : RepeatPurchaseToggleBase
    {
        protected override int SetAvailableStoreInstances()
        {
            return 1;
        }

        protected override IRepeatPurchaseToggleNameInstanceFormatter SetNameInstanceFormatter()
        {
            return null;
        }
    }
}