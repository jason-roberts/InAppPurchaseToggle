﻿namespace InAppPurchaseToggle
{
    public class NameNumberFormatter: IRepeatPurchaseToggleNameInstanceFormatter
    {
        public string Format(string toggleName, int repeatInstanceNumber)
        {
            return toggleName + repeatInstanceNumber;
        }
    }
}