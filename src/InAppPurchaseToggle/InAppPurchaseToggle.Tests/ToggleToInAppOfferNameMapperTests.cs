using InAppPurchaseToggle.Tests.ConcreteTestToggles;
using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class ToggleToInAppOfferNameMapperTests
    {
        [Fact] 
        public void ShouldMapName()
        {
            var sut = new SingleToggleToStoreInAppOfferNameMapper();

            var testToggle = new SinglePurchase1();

            var mappedOfferName = sut.Map(testToggle.GetType());

            Assert.Equal("SinglePurchase1", mappedOfferName);
        }


        [Fact]
        public void ShouldMapUpperCaseName()
        {
            var sut = new SingleToggleToStoreInAppOfferNameMapper();

            var testToggle = new SinglePURCHASE2();

            var mappedOfferName = sut.Map(testToggle.GetType());

            Assert.Equal("SinglePURCHASE2", mappedOfferName);
        }
    }
}
