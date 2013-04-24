namespace InAppPurchaseToggle
{
    public class ToggleToInAppOfferNameMapper
    {
        public string Map(IInAppFeature toggle)
        {
            return toggle.GetType().Name;
        }
    }
}
