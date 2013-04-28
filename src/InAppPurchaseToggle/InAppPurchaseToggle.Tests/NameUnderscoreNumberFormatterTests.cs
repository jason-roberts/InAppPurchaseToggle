﻿using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class NameUnderscoreNumberFormatterTests
    {
        [Fact]
        public void ShouldAppendInstanceNumber()
        {
            var sut = new NameUnderscoreNumberFormatter();

            var inAppOfferFullName = sut.Combine("Coin", 34);

            Assert.Equal("Coin_34", inAppOfferFullName);
        }
    }
}
