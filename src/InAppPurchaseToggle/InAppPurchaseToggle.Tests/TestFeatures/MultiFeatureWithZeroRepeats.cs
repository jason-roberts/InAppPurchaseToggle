namespace InAppPurchaseToggle.Tests.TestFeatures
{
    public class MultiFeatureWithZeroRepeats : RepeatToggleBase
    {
        protected override int SetNumberOfRepeats()
        {
            return 0;
        }
    }
}