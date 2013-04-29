namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class MultiFeatureWithNegativeRepeats : RepeatPurchaseToggleBase
    {
        protected override int SetNumberOfRepeats()
        {
            return -1;
        }
    }
}