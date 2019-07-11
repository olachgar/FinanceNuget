using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class DividendYield
    {
        [Theory]
        [InlineData(100, 20, 500)]
        [InlineData(1000, 20, 5000)]
        [InlineData(1000, 5, 20000)]
        [InlineData(1000000, 20, 5000000)]
        [InlineData(1000000, 5361, 18653.23634)]
        public void DividendYield_Test(double dividendsPerShare, double initialSharePric, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.DividendYield(dividendsPerShare, initialSharePric);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(500, 0)]
        [InlineData(0, 0)]
        public void DividendYield_DivideByZero_Test(double dividendsPerShare, double initialSharePric)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.DividendYield(dividendsPerShare, initialSharePric);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
