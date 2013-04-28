using InAppPurchaseToggle.Tests.TestFeatures;
using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class ToggleToInAppOfferNameMapperTests
    {
        [Fact]
        public void ShouldMapName()
        {
            var sut = new ToggleToInAppOfferNameMapper();

            var testToggle = new Feature1();

            var mappedOfferName = sut.Map(testToggle);

            Assert.Equal("Feature1", mappedOfferName);
        }


        [Fact]
        public void ShouldMapUpperCaseName()
        {
            var sut = new ToggleToInAppOfferNameMapper();

            var testToggle = new FEATURE2();

            var mappedOfferName = sut.Map(testToggle);

            Assert.Equal("FEATURE2", mappedOfferName);
        }
    }
}
