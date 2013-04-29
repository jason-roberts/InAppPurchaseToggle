namespace InAppPurchaseToggle.Tests.HandCodedMocks
{
    // Ideally MoqaLate would have more features so hand mocks would be unnecessary
    internal class WindowsStoreGatewayHandMock : IWindowsStoreGateway
    {
        public bool DefaultIsPurchasedValue { get; set; }
        public string OddOneOutInAppOfferNameToReturnNotDefaultValue { get; set; }

        public bool IsPurchased(string inAppOfferName)
        {
            if (inAppOfferName == OddOneOutInAppOfferNameToReturnNotDefaultValue)
            {
                return !DefaultIsPurchasedValue;
            }

            return DefaultIsPurchasedValue;
        }
    }
}
