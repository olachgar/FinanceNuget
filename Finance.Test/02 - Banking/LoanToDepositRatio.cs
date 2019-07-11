using System;
using Xunit;

namespace Finance.Tests.Banking
{
    public class LoanToDepositRatio
    {
        [Theory]
        [InlineData(100.0,1000.0)]
        public void LoanToDepositRatio_500_06_60_Test(double loans, double deposits)
        {
            // Arrange

            // Act
            var actualResult = Finance.Banking.LoanToDepositRatio(loans, deposits);
            var expectedResult = 10.0;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(500.0, 0)]
        public void LoanToDepositRatio_0_12_Test(double loans, double deposits)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Banking.LoanToDepositRatio(loans, deposits);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }

        [Theory]
        [InlineData(40.0, 1000.0)]
        public void LoanToDepositRatio_1000_06_180_Test(double loans, double deposits)
        {
            // Arrange

            // Act
            var actualResult = Finance.Banking.LoanToDepositRatio(loans, deposits);

            var expectedResult = 4.0;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
