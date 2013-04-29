using System;

namespace InAppPurchaseToggle
{
    public interface ISingleToggleToStoreInAppOfferNameMapper
    {
        string Map(Type concreteToggleType);
    }
}