using System;
using Xunit;

namespace Finance.Tests.Banking
{
    public class DebtToIncomeRatio
    {
        [Fact]
        public void DebtToIncomeRatio_1000_10_2_Test()
        {
            // Arrange
            double monthlyDebtPayments = 1000;
            double grossMonthlyIncome = 10;

            // Act
            var actualResult = Finance.Banking.DebtToIncomeRatio(monthlyDebtPayments, grossMonthlyIncome);
            var expectedResult = 10000.00000;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Fact]
        public void DebtToIncomeRatio_1000_05_24_Test()
        {
            // Arrange
            double monthlyDebtPayments = 1000;
            double grossMonthlyIncome = 0.5;

            // Act
            var actualResult = Finance.Banking.DebtToIncomeRatio(monthlyDebtPayments, grossMonthlyIncome);
            var expectedResult = 200000.00000;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
