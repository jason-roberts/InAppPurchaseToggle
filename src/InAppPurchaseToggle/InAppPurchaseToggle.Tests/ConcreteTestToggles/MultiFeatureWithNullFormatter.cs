namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class MultiFeatureWithNullFormatter : RepeatPurchaseToggleBase
    {
        protected override int SetNumberOfRepeats()
        {
            return 1;
        }

        protected override IRepeatPurchaseToggleNameInstanceFormatter SetNameInstanceFormatter()
        {
            return null;
        }
    }
}