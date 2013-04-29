using System;

namespace InAppPurchaseToggle
{
    public abstract class RepeatPurchaseToggleBase
    {
        private readonly int _totalRepeatsAvailable;

        protected RepeatPurchaseToggleBase()
        {
            WindowsStoreGateway = new RealWindowsStoreGateway();
            InAppOfferNameMapper = new ToggleToInAppOfferNameMapper();
            
// ReSharper disable DoNotCallOverridableMethodsInConstructor
            _totalRepeatsAvailable = SetNumberOfRepeats();
            NameInstanceFormatter = SetNameInstanceFormatter();
// ReSharper restore DoNotCallOverridableMethodsInConstructor

            if (_totalRepeatsAvailable < 1)
            {
                throw new InvalidOperationException(
                    "A repeat toggle must have more than zero instances. Ensure you have correctly implemented the SetNumberOfRepeats method in your concrete toggle.");
            }

            if (NameInstanceFormatter == null)
            {
                throw new NullReferenceException("A custom formatter cannot be null.");
            }
        }

        protected virtual IRepeatPurchaseToggleNameInstanceFormatter SetNameInstanceFormatter()
        {
            return  new NameUnderscoreNumberFormatter();
        }


        public IWindowsStoreGateway WindowsStoreGateway { get; set; }
        public IToggleToInAppOfferNameMapper InAppOfferNameMapper { get; set; }
        public IRepeatPurchaseToggleNameInstanceFormatter NameInstanceFormatter { get; set; }


        public int TotalRepeatsAvailable
        {
            get
            {      
                return _totalRepeatsAvailable;
            }
        }

        public bool IsInstancePurchased(int instance)
        {
            var nameAndInstanceNumber = CreateStoreInAppOfferNameWithInstanceNumber(instance);

            return WindowsStoreGateway.IsPurchased(nameAndInstanceNumber);
        }

        public int GetTotalPurchased()
        {
            int total = 0;

            for (var i = 1; i <= _totalRepeatsAvailable; i++)
            {
                var nameAndInstanceNumber = CreateStoreInAppOfferNameWithInstanceNumber(i);

                if (WindowsStoreGateway.IsPurchased(nameAndInstanceNumber))
                {
                    total++;
                }
            }
            return total;
        }

        private string CreateStoreInAppOfferNameWithInstanceNumber(int instance)
        {
            var baseInAppOfferName = InAppOfferNameMapper.Map(GetType());

            var nameAndInstanceNumber = NameInstanceFormatter.Format(baseInAppOfferName, instance);

            return nameAndInstanceNumber;
        }

        protected abstract int SetNumberOfRepeats();


        public bool IsAllPurchased()
        {
            for (var i = 1; i <= _totalRepeatsAvailable; i++)
            {
                var nameAndInstanceNumber = CreateStoreInAppOfferNameWithInstanceNumber(i);

                if (! WindowsStoreGateway.IsPurchased(nameAndInstanceNumber))
                {
                    return false;
                }
            }

            return true;
        }


        public int GetNextLowestUnpurchasedInstance()
        {
            for (var i = 0; i < _totalRepeatsAvailable; i++)
            {
                var nameAndInstanceNumber = CreateStoreInAppOfferNameWithInstanceNumber(i);

                if (!WindowsStoreGateway.IsPurchased(nameAndInstanceNumber))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}