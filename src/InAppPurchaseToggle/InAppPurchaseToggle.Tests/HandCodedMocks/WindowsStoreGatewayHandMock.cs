namespace InAppPurchaseToggle.Tests.HandCodedMocks
{
    // Ideally MoqaLate would have more features so hand mocks are unnecessary
    internal class WindowsStoreGatewayHandMock : IWindowsStoreGateway
    {
        public bool DefaultIsPurchasedValue { get; set; }
        public string OddOneOitInAppOfferNameToReturnNotDefaultValue { get; set; }

        public bool IsPurchased(string inAppOfferName)
        {
            if (inAppOfferName == OddOneOitInAppOfferNameToReturnNotDefaultValue)
            {
                return !DefaultIsPurchasedValue;
            }

            return DefaultIsPurchasedValue;
        }
    }
}
