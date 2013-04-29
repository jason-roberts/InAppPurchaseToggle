namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class MultiFeatureWithNegativeRepeats : RepeatToggleBase
    {
        protected override int SetNumberOfRepeats()
        {
            return -1;
        }
    }
}