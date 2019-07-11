using System;
using Xunit;

namespace Finance.Tests.Bonds
{
    public class ZeroCouponBondValue
    {
        [Theory]
        [InlineData(10, 5, 60, 0.53536)]
        [InlineData(100, 5, 180, 0.01534)]
        [InlineData(100000, 5, 180, 15.34356)]
        [InlineData(100000, 10, 60, 328.42703)]
        public void ZeroCouponBondValue_Test(double faceValue, double rate, double timeToMaturity, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Bonds.ZeroCouponBondValue(faceValue, rate, timeToMaturity);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(1000, -100, 60)]
        public void ZeroCouponBondValue_DivideByZero_Test(double faceValue, double rate, double timeToMaturity)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Bonds.ZeroCouponBondValue(faceValue, rate, timeToMaturity);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
