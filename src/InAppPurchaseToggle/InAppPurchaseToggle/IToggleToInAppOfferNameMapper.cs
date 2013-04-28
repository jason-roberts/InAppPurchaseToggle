using System;

namespace InAppPurchaseToggle
{
    public interface IToggleToInAppOfferNameMapper
    {
        string Map(Type concreteToggleType);
    }
}