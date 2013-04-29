using System;

namespace InAppPurchaseToggle
{
    public abstract class RepeatPurchaseToggleBase
    {
        private readonly int _availableStoreInstances;

        protected RepeatPurchaseToggleBase()
        {
            StoreGateway = new RealStoreGateway();
            StoreInAppOfferNameMapper = new SingleToggleToStoreInAppOfferNameMapper();
            
// ReSharper disable DoNotCallOverridableMethodsInConstructor
            _availableStoreInstances = SetAvailableStoreInstances();
            NameInstanceFormatter = SetNameInstanceFormatter();
// ReSharper restore DoNotCallOverridableMethodsInConstructor

            if (_availableStoreInstances < 1)
            {
                throw new InvalidOperationException(
                    "A repeat toggle must have more than zero instances. Ensure you have correctly implemented the SetAvailableStoreInstances method in your concrete toggle.");
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


        public IStoreGateway StoreGateway { get; set; }
        public ISingleToggleToStoreInAppOfferNameMapper StoreInAppOfferNameMapper { get; set; }
        public IRepeatPurchaseToggleNameInstanceFormatter NameInstanceFormatter { get; set; }


        public int AvailableStoreInstances
        {
            get
            {      
                return _availableStoreInstances;
            }
        }

        public bool IsInstancePurchased(int instance)
        {
            var nameAndInstanceNumber = CreateStoreInAppOfferNameWithInstanceNumber(instance);

            return StoreGateway.IsPurchased(nameAndInstanceNumber);
        }

        public int GetTotalPurchased()
        {
            int total = 0;

            for (var i = 1; i <= _availableStoreInstances; i++)
            {
                var nameAndInstanceNumber = CreateStoreInAppOfferNameWithInstanceNumber(i);

                if (StoreGateway.IsPurchased(nameAndInstanceNumber))
                {
                    total++;
                }
            }
            return total;
        }

        private string CreateStoreInAppOfferNameWithInstanceNumber(int instance)
        {
            var baseInAppOfferName = StoreInAppOfferNameMapper.Map(GetType());

            var nameAndInstanceNumber = NameInstanceFormatter.Format(baseInAppOfferName, instance);

            return nameAndInstanceNumber;
        }

        protected abstract int SetAvailableStoreInstances();


        public bool IsAllPurchased()
        {
            for (var i = 1; i <= _availableStoreInstances; i++)
            {
                var nameAndInstanceNumber = CreateStoreInAppOfferNameWithInstanceNumber(i);

                if (! StoreGateway.IsPurchased(nameAndInstanceNumber))
                {
                    return false;
                }
            }

            return true;
        }


        public int GetNextLowestUnpurchasedInstance()
        {
            for (var i = 0; i < _availableStoreInstances; i++)
            {
                var nameAndInstanceNumber = CreateStoreInAppOfferNameWithInstanceNumber(i);

                if (!StoreGateway.IsPurchased(nameAndInstanceNumber))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}