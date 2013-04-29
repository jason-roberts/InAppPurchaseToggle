using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class NameNumberFormatterTests
    {
        [Fact]
        public void ShouldAppendInstanceNumberAfterUnderscore()
        {
            var sut = new NameNumberFormatter();

            var inAppOfferFullName = sut.Combine("Coin", 34);

            Assert.Equal("Coin34", inAppOfferFullName);
        }
    }
}
