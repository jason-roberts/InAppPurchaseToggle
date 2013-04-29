namespace InAppPurchaseToggle
{
    public abstract class SinglePurchaseToggleBase
    {
        protected SinglePurchaseToggleBase()
        {
            StoreGateway = new RealStoreGateway();
            StoreInAppOfferNameMapper = new SingleToggleToStoreInAppOfferNameMapper();
        }

        public IStoreGateway StoreGateway { get; set; }
        public ISingleToggleToStoreInAppOfferNameMapper StoreInAppOfferNameMapper { get; set; }

        public bool IsPurchased
        {
            get
            {
                var inAppOfferName = StoreInAppOfferNameMapper.Map(this.GetType());

                var isOfferPurchased = StoreGateway.IsPurchased(inAppOfferName);

                return isOfferPurchased;
            }
        }
    }
}