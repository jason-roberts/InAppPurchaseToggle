namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class MultiFeatureWithNullFormatter : RepeatToggleBase
    {
        protected override int SetNumberOfRepeats()
        {
            return 1;
        }

        protected override IRepeatToggleInstanceNumberConcatinator SetInstanceNumberFormatter()
        {
            return null;
        }
    }
}