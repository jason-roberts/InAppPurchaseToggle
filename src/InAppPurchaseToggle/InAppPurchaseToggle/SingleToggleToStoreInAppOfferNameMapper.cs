using System;

namespace InAppPurchaseToggle
{
    public class SingleToggleToStoreInAppOfferNameMapper : ISingleToggleToStoreInAppOfferNameMapper
    {
        public string Map(Type concreteToggleType)
        {
            return concreteToggleType.Name;
        }
    }
}