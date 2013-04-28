using System;

namespace InAppPurchaseToggle
{
    public abstract class RepeatToggleBase
    {
        private readonly int _totalRepeatsAvailable;

        protected RepeatToggleBase()
        {
            WindowsStoreGateway = new RealWindowsStoreGateway();
            InAppOfferNameMapper = new ToggleToInAppOfferNameMapper();
// ReSharper disable DoNotCallOverridableMethodsInConstructor
            _totalRepeatsAvailable = SetNumberOfRepeats();
// ReSharper restore DoNotCallOverridableMethodsInConstructor
        }

        public IWindowsStoreGateway WindowsStoreGateway { get; set; }
        public IToggleToInAppOfferNameMapper InAppOfferNameMapper { get; set; }
        public int TotalRepeatsAvailable
        {
            get
            {
                if (_totalRepeatsAvailable < 1)
                {
                    throw new InvalidOperationException("A multi toggle must have more than zero instances. Ensure you have correctly implemented the SetNumberOfRepeats method in your concrete toggle.");
                }
                return _totalRepeatsAvailable;
            }
        }

        //protected virtual void InitNumberOfRepeats()
        //{
        //    _totalRepeatsAvailable = 0;
        //}


        protected abstract int SetNumberOfRepeats();

        //public bool IsPurchased
        //{
        //    get
        //    {
        //        var inAppOfferName = InAppOfferNameMapper.Map(this);

        //        var isOfferPurchased = WindowsStoreGateway.LookupActiveStatus(inAppOfferName);

        //        return isOfferPurchased;
        //    }
        //}
    }
}