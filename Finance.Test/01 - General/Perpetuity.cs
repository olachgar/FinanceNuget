using System;
using Xunit;

namespace Finance.Tests.General
{
    public class Perpetuity
    {
        [Theory]
        [InlineData(10, 1, 1000)]
        [InlineData(100, 1, 10000)]
        [InlineData(10000, 1, 1000000)]
        [InlineData(10000, 10, 100000)]
        [InlineData(100000, 15, 666666.66667)]
        public void Perpetuity_Test(double couponPerPeriod, int discountRate, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.Perpetuity(couponPerPeriod, discountRate);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(1000, 0)]
        public void Perpetuity_DivideByZero_Test(double couponPerPeriod, int discountRate)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.Perpetuity(couponPerPeriod, discountRate);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
