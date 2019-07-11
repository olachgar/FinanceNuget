using System;
using Xunit;

namespace Finance.Tests.Bonds
{
    public class ZeroCouponBondYield
    {
        [Theory]
        [InlineData(100, 10, 60, 3.91223)]
        [InlineData(1000, 10, 60, 7.97752)]
        [InlineData(1000, 5, 60, 9.23215)]
        [InlineData(100000, 5, 180, 5.65611)]
        public void ZeroCouponBondYield_Test(double faceValue, double presentValue, double timeToMaturity, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Bonds.ZeroCouponBondYield(faceValue, presentValue, timeToMaturity);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(500, 0, 60)]
        [InlineData(500, 100, 0)]
        [InlineData(500, 0, 0)]
        public void ZeroCouponBondYield_DivideByZero_Test(double faceValue, double presentValue, double timeToMaturity)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Bonds.ZeroCouponBondYield(faceValue, presentValue, timeToMaturity);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
