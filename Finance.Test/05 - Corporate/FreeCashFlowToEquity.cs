using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class FreeCashFlowToEquity
    {
        [Theory]
        [InlineData(1000, 50, 100, 15, 865)]
        [InlineData(1500, 50, 100, 15, 1365)]
        [InlineData(9000, 40, 10, 450, 9400)]
        [InlineData(100000, 9000, 0, 900, 91900)]
        [InlineData(1000000, 5000, 900, 70000, 1064100)]
        public void FreeCashFlowToEquity_Test(double netIncome, double capitalExpenditures, double changeInWorkingCapital, double netBorrowing, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Corporate.FreeCashFlowToEquity(netIncome, capitalExpenditures, changeInWorkingCapital, netBorrowing);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
