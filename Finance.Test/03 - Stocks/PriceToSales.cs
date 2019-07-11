using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class PriceToSales
    {
        [Theory]
        [InlineData(500, 6, 83.33333)]
        [InlineData(1000, 6, 166.66667)]
        [InlineData(1000, 5, 200)]
        [InlineData(5000, 5, 1000)]
        [InlineData(1000000, 3325, 300.75188)]
        public void PriceToSales_Test(double sharePrice, double salesPerShare, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.PriceToSales(sharePrice, salesPerShare);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 0)]
        [InlineData(500, 0)]
        public void PriceToSales_DivideByZero_Test(double sharePrice, double salesPerShare)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.PriceToSales(sharePrice, salesPerShare);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
