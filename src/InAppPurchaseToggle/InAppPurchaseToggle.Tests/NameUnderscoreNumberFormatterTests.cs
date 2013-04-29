using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class NameUnderscoreNumberFormatterTests
    {
        [Fact]
        public void ShouldAppendInstanceNumberAfterUnderscore()
        {
            var sut = new NameUnderscoreNumberFormatter();

            var inAppOfferFullName = sut.Format("Coin", 34);

            Assert.Equal("Coin_34", inAppOfferFullName);
        }
    }
}
