using System;
using Xunit;

namespace Finance.Tests.Banking
{
    public class LoanRemainingBalance
    {
        [Theory]
        [InlineData(100000,500,2,60, 271077.30913)]
        [InlineData(200000, 500, 4, 60, 1984930.13901)]
        [InlineData(100, 5, 10, 10, 179.68712)]
        [InlineData(100, 1, 10, 10, 243.43682)]
        [InlineData(100, 1, 10, 5, 154.9459)]
        public void LoanRemainingBalance_Test(double presentValue, double payment, double rateOfpayments, double numberOfpayments, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Banking.LoanRemainingBalance(presentValue,
                                                                    payment,
                                                                    rateOfpayments,
                                                                    numberOfpayments);
            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(100000, 500, 0, 60)]
        public void LoanRemainingBalance_DivideByZero_Test(double presentValue, double payment, double rateOfpayments, double numberOfpayments)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Banking.LoanRemainingBalance(presentValue,
                                                                             payment,
                                                                             rateOfpayments,
                                                                             numberOfpayments);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
