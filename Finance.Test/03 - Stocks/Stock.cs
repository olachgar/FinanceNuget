using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class Stock
    {
        [Theory]
        [InlineData(200, 5, 4000)]
        [InlineData(250, 5, 5000)]
        [InlineData(1000000, 15, 6666666.66667)]
        [InlineData(1000000, 28, 3571428.57143)]
        [InlineData(100000, 65, 153846.15385)]
        public void Stock_ZeroGrowth_Test(double annualDividends, double annualRequiredReturn, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.Stock(annualDividends, annualRequiredReturn);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 0)]
        [InlineData(500, 0)]
        public void Stock_ZeroGrowth_DivideByZero_Test(double annualDividends, double annualRequiredReturn)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.Stock(annualDividends, annualRequiredReturn);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }



        [Theory]
        [InlineData(200, 12, 3, 2222.22222)]
        [InlineData(2000, 6, 3, 66666.66667)]
        [InlineData(5000, 4, 3, 500000)]
        [InlineData(5000, 4, 1, 166666.66667)]
        [InlineData(10, 4, 1, 333.33333)]
        public void Stock_ConstantGrowth_Test(double estimatedDividendsForNextPeriod, double requiredRateOfReturn, double growthRate, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.Stock(estimatedDividendsForNextPeriod, requiredRateOfReturn, growthRate);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(500, 0, 0)]
        [InlineData(500, 10, 10)]
        [InlineData(500, 3, 3)]
        public void Stock_ConstantGrowth_DivideByZero_Test(double estimatedDividendsForNextPeriod, double requiredRateOfReturn, double growthRate)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.Stock(estimatedDividendsForNextPeriod, requiredRateOfReturn, growthRate);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
