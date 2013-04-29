using InAppPurchaseToggle.Tests.ConcreteTestToggles;
using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class SimulatedNeverPurchasedStoreGatewayTests
    {
        [Fact]
        public void ShouldAlwaysReturnInAppHasBeenPurchased()
        {
            var sut = new SinglePurchase1 {StoreGateway = new SimulatedNeverPurchasedStoreGateway()};

            Assert.False(sut.IsPurchased);
        }
   }
}
