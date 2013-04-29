using System;

namespace InAppPurchaseToggle
{
    public interface IToggleToStoreInAppOfferNameMapper
    {
        string Map(Type concreteToggleType);
    }
}