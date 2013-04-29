using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class NameNumberFormatterTests
    {
        [Fact]
        public void ShouldAppendInstanceNumberAfterUnderscore()
        {
            var sut = new RepeatPurchaseNameInstanceFormatter();

            var inAppOfferFullName = sut.Format("Coin", 34);

            Assert.Equal("Coin34", inAppOfferFullName);
        }
    }
}
