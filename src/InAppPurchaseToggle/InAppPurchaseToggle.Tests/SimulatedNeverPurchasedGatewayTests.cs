using InAppPurchaseToggle.Tests.ConcreteTestToggles;
using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class SimulatedNeverPurchasedGatewayTests
    {
        [Fact]
        public void ShouldAlwaysReturnInAppHasBeenPurchased()
        {
            var sut = new Feature1 {StoreGateway = new SimulatedNeverPurchasedStoreGateway()};

            Assert.False(sut.IsPurchased);
        }
   }
}
