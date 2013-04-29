using InAppPurchaseToggle.Tests.ConcreteTestToggles;
using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class SimulatedAlwaysPurchasedStoreGatewayTests
    {
        [Fact]
        public void ShouldAlwaysReturnInAppHasBeenPurchased()
        {
            var sut = new SinglePurchase1 {StoreGateway = new SimulatedAlwaysPurchasedStoreGateway()};

            Assert.True(sut.IsPurchased);
        }
   }
}
