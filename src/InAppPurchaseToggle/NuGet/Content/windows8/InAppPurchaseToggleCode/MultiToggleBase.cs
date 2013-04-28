namespace InAppPurchaseToggle
{
    public abstract class MultiToggleBase
    {
        protected MultiToggleBase()
        {
            WindowsStoreGateway = new RealWindowsStoreGateway();
            InAppOfferNameMapper = new ToggleToInAppOfferNameMapper();
        }

        public IWindowsStoreGateway WindowsStoreGateway { get; set; }
        public IToggleToInAppOfferNameMapper InAppOfferNameMapper { get; set; }

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