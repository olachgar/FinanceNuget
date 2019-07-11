using System;
using Xunit;

namespace Finance.Tests.Banking
{
    public class LoanToValueRatio
    {
        [Theory]
        [InlineData(100.0,1000.0)]
        public void LoanToDepositRatio_500_06_60_Test(double loanAmount, double valueOfCollatral)
        {
            // Arrange

            // Act
            var actualResult = Finance.Banking.LoanToValueRatio(loanAmount, valueOfCollatral);
            var expectedResult = 10.0;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(500.0, 0)]
        public void LoanToValueRatio_150_0_Test(double loanAmount, double valueOfCollatral)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Banking.LoanToValueRatio(loanAmount, valueOfCollatral);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Theory]
        [InlineData(40.0, 1000.0)]
        public void LoanToValueRatio_1000_06_180_Test(double loanAmount, double valueOfCollatral)
        {
            // Arrange

            // Act
            var actualResult = Finance.Banking.LoanToValueRatio(loanAmount, valueOfCollatral);

            var expectedResult = 4.0;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
