using System;

namespace InAppPurchaseToggle
{
    public class ToggleToStoreInAppOfferNameMapper : IToggleToStoreInAppOfferNameMapper
    {
        public string Map(Type concreteToggleType)
        {
            return concreteToggleType.Name;
        }
    }
}