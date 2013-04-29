namespace InAppPurchaseToggle
{
    public abstract class SinglePurchaseToggleBase
    {
        protected SinglePurchaseToggleBase()
        {
            WindowsStoreGateway = new RealWindowsStoreGateway();
            InAppOfferNameMapper = new ToggleToInAppOfferNameMapper();
        }

        public IWindowsStoreGateway WindowsStoreGateway { get; set; }
        public IToggleToInAppOfferNameMapper InAppOfferNameMapper { get; set; }

        public bool IsPurchased
        {
            get
            {
                var inAppOfferName = InAppOfferNameMapper.Map(this.GetType());

                var isOfferPurchased = WindowsStoreGateway.IsPurchased(inAppOfferName);

                return isOfferPurchased;
            }
        }
    }
}