using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class TaxEquivalentYield
    {
        [Theory]
        [InlineData(5, 4, 5.20833)]
        [InlineData(15, 4, 15.625)]
        [InlineData(85, 10, 94.44444)]
        [InlineData(95, 40, 158.33333)]
        [InlineData(100, 4, 104.16667)]
        public void TaxEquivalentYield_Test(double taxFreeYield, double marginalTaxRate, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.TaxEquivalentYield(taxFreeYield, marginalTaxRate);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 100)]
        [InlineData(500, 100)]
        public void TaxEquivalentYield_DivideByZero_Test(double taxFreeYield, double marginalTaxRate)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.TaxEquivalentYield(taxFreeYield, marginalTaxRate);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
