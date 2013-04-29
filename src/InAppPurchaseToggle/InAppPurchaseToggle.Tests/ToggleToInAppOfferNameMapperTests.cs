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

            var testToggle = new Feature1();

            var mappedOfferName = sut.Map(testToggle.GetType());

            Assert.Equal("Feature1", mappedOfferName);
        }


        [Fact]
        public void ShouldMapUpperCaseName()
        {
            var sut = new SingleToggleToStoreInAppOfferNameMapper();

            var testToggle = new FEATURE2();

            var mappedOfferName = sut.Map(testToggle.GetType());

            Assert.Equal("FEATURE2", mappedOfferName);
        }
    }
}
