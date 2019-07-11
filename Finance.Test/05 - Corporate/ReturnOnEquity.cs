using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class ReturnOnEquity
    {   
        [Fact]
        public void debtRatio_5_2_Test()
        {
            // Arrange 
            double netIncome = 5;
            double avgStockholderEquity = 2;

            // Act
            var actualResult = Finance.Corporate.DebtRatio(netIncome, avgStockholderEquity);
            var expectedResult = 2.5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void debtRatio_100_0_Test()
        {
            // Arrange 
            double netIncome = 100;
            double avgStockholderEquity = 0;

            // Act
            Action actualResult = () => Finance.Corporate.DebtRatio(netIncome, avgStockholderEquity);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void debtRatio_2500000_3000000_Test()
        {
            // Arrange 
            double netIncome = 2500000;
            double avgStockholderEquity = 3000000;

            // Act
            var actualResult = Finance.Corporate.DebtRatio(netIncome, avgStockholderEquity);
            var expectedResult = 0.83333333333333337;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
