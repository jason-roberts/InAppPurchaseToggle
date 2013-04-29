namespace InAppPurchaseToggle.Tests.ConcreteTestToggles
{
    public class MultiFeatureWithZeroRepeats : RepeatToggleBase
    {
        protected override int SetNumberOfRepeats()
        {
            return 0;
        }
    }
}