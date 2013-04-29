﻿using System;
using InAppPurchaseToggle.Tests.ConcreteTestToggles;
using InAppPurchaseToggle.Tests.HandCodedMocks;
using MoqaLate.Autogenerated;
using Xunit;

namespace InAppPurchaseToggle.Tests
{
    public class RepeatToggleTests
    {
        [Fact]
        public void ShouldDefaultToRealWindowsStoreGateway()
        {
            var sut = new MultiFeatureWith123Instances();

            Assert.IsType(typeof (RealWindowsStoreGateway), sut.WindowsStoreGateway);
        }


        [Fact]
        public void ShouldDefaultToUnderscoreIntanceNumberFormatter()
        {
            var sut = new MultiFeatureWith123Instances();

            Assert.IsType(typeof(NameUnderscoreNumberFormatter), sut.ToggleInstanceNumberFormatter);
        }

        [Fact]
        public void ShouldReturnTotalOffersAvailable()
        {
            var sut = new MultiFeatureWith123Instances();

            var totalOffers = sut.TotalRepeatsAvailable;
            
            Assert.Equal(123, totalOffers);
        }


        [Fact]
        public void ShouldErrorIfToggleSetsZeroRepeats()
        {
            Assert.Throws<InvalidOperationException>(() => { new MultiFeatureWithZeroRepeats(); });
        }


        [Fact]
        public void ShouldErrorIfDerivedToggleWithNegativeRepeats()
        {
            Assert.Throws<InvalidOperationException>(() => { new MultiFeatureWithNegativeRepeats(); });
        }
        

        [Fact]
        public void ShouldCallGatewayAsManyTimesAsThereAreOfferNumbersWhenCalculatingTotalPurchased()
        {
            var mockGateway = new WindowsStoreGatewayMoqaLate();
            mockGateway.IsPurchasedSetReturnValue(true);

            var sut = new MultiFeatureWith123Instances()
                          {
                              WindowsStoreGateway = mockGateway
                          };

            sut.GetTotalPurchased();

            Assert.Equal(123, mockGateway.IsPurchasedTimesCalled());
        }


         [Fact]
         public void ShouldCallNameFormatterAsManyTimesAsThereAreOfferNumbersWhenCalculatingTotalPurchased()
         {
             var mockGateway = new WindowsStoreGatewayMoqaLate();
             mockGateway.IsPurchasedSetReturnValue(true);

             var mockConcat = new  RepeatToggleInstanceNumberConcatinatorMoqaLate();

             var sut = new MultiFeatureWith123Instances()
             {
                 WindowsStoreGateway = mockGateway,
                 ToggleInstanceNumberFormatter = mockConcat
             };

             sut.GetTotalPurchased();

             Assert.Equal(123, mockConcat.CombineTimesCalled());
         }
        

         [Fact]
         public void ShouldReturnIfSpecificInstanceHasBeenPurchased()
         {
             var mockGateway = new WindowsStoreGatewayMoqaLate();
             mockGateway.IsPurchasedSetReturnValue(true);

             var sut = new MultiFeatureWith123Instances()
             {
                 WindowsStoreGateway = mockGateway
             };

             var isPurchased = sut.IsInstancePurchased(123);

             Assert.True(isPurchased);

             // TODO: this should prob be in sep test
             // Due to current limitations with MoqaLate, we can only get what the last call was for a particular method
             mockGateway.IsPurchasedWasCalledWith("MultiFeatureWith123Instances_123");


             // test the negative version
             mockGateway.IsPurchasedSetReturnValue(false);
             
             isPurchased = sut.IsInstancePurchased(123);

             Assert.False(isPurchased);

             // TODO: this should prob be in sep test
             // Due to current limitations with MoqaLate, we can only get what the last call was for a particular method
             mockGateway.IsPurchasedWasCalledWith("MultiFeatureWith123Instances_123");
         }


         [Fact]
         public void ShouldCalculateIfAllInstancesHaveNotBeenPurchased()
         {
             var mockGateway = new WindowsStoreGatewayHandMock
                                   {
                                       DefaultIsPurchasedValue = true,
                                       OddOneOutInAppOfferNameToReturnNotDefaultValue =
                                           "MultiFeatureWith123Instances_99"
                                   };

             var sut = new MultiFeatureWith123Instances()
             {
                 WindowsStoreGateway = mockGateway
             };

             var allPurchased = sut.IsAllPurchased();

             Assert.False(allPurchased);
         }


         [Fact]
         public void ShouldCalculateIfAllInstancesHaveBeenPurchased()
         {
             var mockGateway = new WindowsStoreGatewayMoqaLate();
             mockGateway.IsPurchasedSetReturnValue(true);

             var sut = new MultiFeatureWith123Instances()
             {
                 WindowsStoreGateway = mockGateway
             };

             var allPurchased = sut.IsAllPurchased();

             Assert.True(allPurchased);
         }
        

         [Fact]
         public void ShouldCalculateNextLowestUnPurchased()
         {
             var mockGateway = new WindowsStoreGatewayHandMock
             {
                 DefaultIsPurchasedValue = true,
                 OddOneOutInAppOfferNameToReturnNotDefaultValue =
                     "MultiFeatureWith123Instances_99"
             };

             var sut = new MultiFeatureWith123Instances()
             {
                 WindowsStoreGateway = mockGateway
             };

             var nextUnpurchasedInstance = sut.GetNextLowestUnpurchasedInstance();

             Assert.Equal(99, nextUnpurchasedInstance);
         }


         [Fact]
         public void ShouldCalculateNextLowestUnPurchasedWhenAllHaveBeenPurchased()
         {
             var mockGateway = new WindowsStoreGatewayMoqaLate();
             mockGateway.IsPurchasedSetReturnValue(true);

             var sut = new MultiFeatureWith123Instances()
             {
                 WindowsStoreGateway = mockGateway
             };

             var nextUnpurchasedInstance = sut.GetNextLowestUnpurchasedInstance();

             Assert.Equal(-1, nextUnpurchasedInstance);
         }


         [Fact]
         public void ShouldUseCustomFormatterIfSetInDerivedToggle()
         {
             var mockGateway = new WindowsStoreGatewayMoqaLate();
             mockGateway.IsPurchasedSetReturnValue(true);

             var sut = new MultiFeatureWithNonDefualtFormatter()
             {
                 WindowsStoreGateway = mockGateway
             };

             var confuguredFormatter = sut.ToggleInstanceNumberFormatter;

             Assert.IsType(typeof(RepeatToggleInstanceNumberConcatinatorMoqaLate), confuguredFormatter);
         }


         [Fact]
         public void ShouldErrorWhenNullUseCustomFormatterSetInDerivedToggle()
         {
             Assert.Throws<NullReferenceException>(() => { new MultiFeatureWithNullFormatter(); });
         }
    }
}