namespace InAppPurchaseToggle.Tests.TestFeatures
{
    public class MultiFeatureWithNegativeRepeats : RepeatToggleBase
    {
        protected override int SetNumberOfRepeats()
        {
            return -1;
        }
    }
}