using System;
using Xunit;

namespace Finance.Tests.Banking
{
    public class LoanBalloonBalance
    {
        [Fact]
        public void BalloonLoanPayments_100000_843_05_60_Test()
        {
            // Arrange
            double originalBalance = 100000.00;
            double payment = 843.86;
            double rateOfpayment = 0.50;
            double numberOfpayment = 60;

            // Act
            var actualResult = Finance.Banking.LoanBalloonBalance(originalBalance, 
                                                                   payment, 
                                                                   rateOfpayment, 
                                                                   numberOfpayment);
            var expectedResult = 76008.87731;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Fact]
        public void BalloonLoanPayments_200000_843_05_60_Test()
        {
            // Arrange
            double originalBalance = 200000.00;
            double payment = 843.86;
            double rateOfpayment = 0.50;
            double numberOfpayment = 60;

            // Act
            var actualResult = Finance.Banking.LoanBalloonBalance(originalBalance,
                                                                   payment,
                                                                   rateOfpayment,
                                                                   numberOfpayment);

            var expectedResult = 210893.89256;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
