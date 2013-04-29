namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class MultiFeatureWithZeroRepeats : RepeatPurchaseToggleBase
    {
        protected override int SetNumberOfRepeats()
        {
            return 0;
        }
    }
}