using System;

namespace InAppPurchaseToggle
{
    public class ToggleToInAppOfferNameMapper : IToggleToInAppOfferNameMapper
    {
        public string Map(Type concreteToggleType)
        {
            return concreteToggleType.Name;
        }
    }
}