using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class DilutedEarningsPerShare
    {
        [Theory]
        [InlineData(10, 10, 10, 0.5)]
        [InlineData(100, 10, 10, 5)]
        [InlineData(100000, 6, 10, 6250)]
        [InlineData(1000000, 20, 7, 37037.03704)]
        [InlineData(1000000, 238, 15, 3952.56917)]
        public void DilutedEarningsPerShare_Test(double netIncome, double avgShares, double otherConvertibleInstruments, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.DilutedEarningsPerShare(netIncome, avgShares, otherConvertibleInstruments);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(500, 0, 0)]
        [InlineData(500, -1, 1)]
        [InlineData(500.0, 2, -2)]
        public void DilutedEarningsPerShare_DivideByZero_Test(double netIncome, double avgShares, double otherConvertibleInstruments)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.DilutedEarningsPerShare(netIncome, avgShares, otherConvertibleInstruments);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
