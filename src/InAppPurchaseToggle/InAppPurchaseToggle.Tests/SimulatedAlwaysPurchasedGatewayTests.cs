using InAppPurchaseToggle.Tests.ConcreteTestToggles;
using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class SimulatedAlwaysPurchasedGatewayTests
    {
        [Fact]
        public void ShouldAlwaysReturnInAppHasBeenPurchased()
        {
            var sut = new Feature1 {StoreGateway = new SimulatedAlwaysPurchasedStoreGateway()};

            Assert.True(sut.IsPurchased);
        }
   }
}
