﻿using System;
using InAppPurchaseToggle.Tests.TestFeatures;
using MoqaLate.Autogenerated;
using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class ConcreteRepeatToggleTests
    {
        [Fact]
        public void ShouldDefaultToRealWindowsStoreGateway()
        {
            var sut = new MultiFeatureWith123Instances();

            Assert.IsType(typeof (RealWindowsStoreGateway), sut.WindowsStoreGateway);
        }


        [Fact]
        public void ShouldReturnTotalRepeatOffers()
        {
            var sut = new MultiFeatureWith123Instances();

            var totalOffers = sut.TotalRepeatsAvailable;
            
            Assert.Equal(123, totalOffers);
        }


        [Fact]
        public void ShouldErrorIfDerivedToggleWithZeroRepeats()
        {
            var sut = new MultiFeatureWithZeroRepeats();

            Assert.Throws<InvalidOperationException>(() => { var totalOffers = sut.TotalRepeatsAvailable; });            
        }


        [Fact]
        public void ShouldErrorIfDerivedToggleWithNegativeRepeats()
        {
            var sut = new MultiFeatureWithNegativeRepeats();

            Assert.Throws<InvalidOperationException>(() => { var totalOffers = sut.TotalRepeatsAvailable; });
        }

        // runtime ex if derived toggle hasn't set (by overriding totatl) or is zero or 1??

        //[Fact]
        //public void ShouldCallSpecifiedWindowsStoreGatewayAsManyTimesAsThereAreOfferNumbers()
        //{
        //    var mockGateway = new WindowsStoreGatewayMoqaLate();
        //    mockGateway.LookupActiveStatusSetReturnValue(true);

        //    var sut = new MultiFeature1
        //                  {
        //                      WindowsStoreGateway = mockGateway
        //                  };

        //    var result = sut.IsPurchased;

        //    Assert.True(mockGateway.LookupActiveStatusWasCalledWith("MultiFeature1"));
        //    Assert.True(result);
        //}


        //[Fact]
        //public void ShouldMapName()
        //{
        //    var mockNameMapper = new ToggleToInAppOfferNameMapperMoqaLate();

        //    var sut = new Feature1
        //                  {
        //                      WindowsStoreGateway = new WindowsStoreGatewayMoqaLate(),
        //                      InAppOfferNameMapper = mockNameMapper
        //                  };

        //    var dontCare = sut.IsPurchased;

        //    Assert.True(mockNameMapper.MapWasCalledWith(sut));
        //}
    }
}