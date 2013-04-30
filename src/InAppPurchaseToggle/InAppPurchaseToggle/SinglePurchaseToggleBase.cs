namespace InAppPurchaseToggle
{
    /// <summary>
    /// Inherit from this if you need to create a single (non repeat) toggle
    /// </summary>
    public abstract class SinglePurchaseToggleBase
    {
        protected SinglePurchaseToggleBase()
        {
            StoreGateway = new RealStoreGateway();
            StoreInAppOfferNameMapper = new SingleToggleToStoreInAppOfferNameMapper();
        }

        /// <summary>
        /// The Store gateway to use
        /// </summary>
        public IStoreGateway StoreGateway { get; set; }

        /// <summary>
        /// The mapper that uses the concrete toggle type and maps it the 
        /// name of the in app offer as configured in the Store
        /// </summary>
        public ISingleToggleToStoreInAppOfferNameMapper StoreInAppOfferNameMapper { get; set; }

        /// <summary>
        /// Determines if the user has purchased this toggle
        /// </summary>
        public bool IsPurchased
        {
            get
            {
                var inAppOfferName = StoreInAppOfferNameMapper.Map(GetType());

                var isOfferPurchased = StoreGateway.IsPurchased(inAppOfferName);

                return isOfferPurchased;
            }
        }
    }
}