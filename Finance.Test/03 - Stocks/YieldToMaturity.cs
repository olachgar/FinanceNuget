using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class YieldToMaturity
    {
        [Theory]
        [InlineData(100, 1000, 920, 10, 11.25)]
        [InlineData(10, 10, 10, 10, 100)]
        [InlineData(100, 10, 10, 10, 1000)]
        [InlineData(10, 100, 10, 10, 34.54545)]
        [InlineData(10, 10, 100, 10, 1.81818)]
        [InlineData(10, 10, 10, 100, 100)]
        public void YieldToMaturity_Test(double annualCoupon, double faceValue, double price, double yearsToMaturity, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.YieldToMaturity(annualCoupon, faceValue, price, yearsToMaturity);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(500, 500, 500, 0)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(0, 0, 0, 500)]
        [InlineData(500, 0, 0, 500)]
        [InlineData(500, -2, 2, 500)]
        [InlineData(500, 1, -1, 500)]
        public void YieldToMaturity_DivideByZero_Test(double annualCoupon, double faceValue, double price, double yearsToMaturity)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.YieldToMaturity(annualCoupon, faceValue, price, yearsToMaturity);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
