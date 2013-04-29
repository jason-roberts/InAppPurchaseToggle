namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class MultiFeatureWith123Instances : RepeatToggleBase
    {
        protected override int SetNumberOfRepeats()
        {
            return 123;
        }
    }
}