namespace InAppPurchaseToggle
{
    public class ToggleToInAppOfferNameMapper : IToggleToInAppOfferNameMapper
    {
        public string Map(ToggleBase toggle)
        {
            return toggle.GetType().Name;
        }
    }
}