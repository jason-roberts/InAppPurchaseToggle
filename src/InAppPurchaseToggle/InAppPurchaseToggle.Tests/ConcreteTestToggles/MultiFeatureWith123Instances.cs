namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class MultiFeatureWith123Instances : RepeatPurchaseToggleBase
    {
        protected override int SetNumberOfRepeats()
        {
            return 123;
        }
    }
}