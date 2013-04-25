using InAppPurchaseToggle.PortableCoreTests.TestFeatures;
using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class SimulatedAlwaysPurchasedGatewayTests
    {
        [Fact]
        public void ShouldAlwaysReturnInAppHasBeenPurchased()
        {
            var sut = new Feature1 {WindowsStoreGateway = new SimulatedAlwaysPurchasedGateway()};

            Assert.True(sut.IsPurchased);
        }
   }
}
