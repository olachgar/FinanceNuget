using System;
using Xunit;

namespace Finance.Tests.General
{
    public class GrowingPerpetuityPresentValue
    {
        [Theory]
        [InlineData(100000, 5, 1, 2500000)]
        [InlineData(10000, 5, 1, 250000)]
        [InlineData(10000, 5, 3, 500000)]
        [InlineData(100000, 3, 1, 5000000)]
        public void GrowingPerpetuityPresentValue_Test(double dividendAtPeriod1, double discountRate, double growthRate, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.GrowingPerpetuityPresentValue(dividendAtPeriod1, discountRate, growthRate);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 2, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(0, 5, 5)]
        [InlineData(0, 56, 56)]
        public void GrowingPerpetuityPresentValue_DivideByZero_Test(double dividendAtPeriod1, double discountRate, double growthRate)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.GrowingPerpetuityPresentValue(dividendAtPeriod1, discountRate, growthRate);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
