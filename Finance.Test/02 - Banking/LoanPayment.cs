using System;
using Xunit;

namespace Finance.Tests.Banking
{
    public class LoanPayment
    {
        [Theory]
        [InlineData(500.0,6.0,60)]
        public void LoanPayments_500_06_60_Test(double presentValued, double ratePerPeriod, double numberOfPeriod)
        {
            // Arrange

            // Act
            var actualResult = Finance.Banking.LoanPayment(presentValued,
                                                           ratePerPeriod, 
                                                           numberOfPeriod);
            var expectedResult = 30.93786;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(500.0, 0, 60)]
        public void LoanPayments_0_12_Test(double presentValued, double ratePerPeriod, double numberOfPeriod)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Banking.LoanPayment(presentValued,
                                                                    ratePerPeriod,
                                                                    numberOfPeriod);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }

        [Theory]
        [InlineData(1000.0, 6.0, 180)]
        public void LoanPayments_1000_06_180_Test(double presentValued, double ratePerPeriod, double numberOfPeriod)
        {
            // Arrange

            // Act
            var actualResult = Finance.Banking.LoanPayment(presentValued,
                                                           ratePerPeriod,
                                                           numberOfPeriod);

            var expectedResult = 60.00167;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
