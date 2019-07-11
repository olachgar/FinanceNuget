using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class FreeCashFlowToFirm
    {
        [Theory]
        [InlineData(1, 2, 3, 4, -6.02)]
        [InlineData(1000, 2, 3, 4, 973.00)]
        [InlineData(9000, 5, 3, 4, 8543)]
        [InlineData(100000, 5, 8023, 4, 86973)]
        [InlineData(1000000, 15, 10000, 14, 839986)]
        public void FreeCashFlowToFirm_Test(double eBIT, double capitalExpenditures, double changeInWorkingCapital, double taxRate, double expectedResult)
        {
            //TODO
            // Arrange

            // Act
            //var actualResult = Finance.Corporate.FreeCashFlowToFirm(eBIT, capitalExpenditures, changeInWorkingCapital, taxRate);

            // Assert
            //Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
