using InAppPurchaseToggle.PortableCoreTests.TestFeatures;
using InAppPurchaseToggle.WindowsStore;
using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class SimulatedNeverPurchasedGatewayTests
    {
        [Fact]
        public void ShouldAlwaysReturnInAppHasBeenPurchased()
        {
            var sut = new Feature1 {WindowsStoreGateway = new SimulatedNeverPurchasedGateway()};

            Assert.False(sut.IsPurchased);
        }
   }
}
