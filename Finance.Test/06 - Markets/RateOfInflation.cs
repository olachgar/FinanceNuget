using System;
using Xunit;

namespace Finance.Tests.Markets
{
    public class AssetToSalesRatio
    {
        [Theory]
        [InlineData(5, 2, -60)]
        [InlineData(2, 5, 150)]
        [InlineData(1, 2, 100)]
        [InlineData(1, 1, 0)]
        public void RateOfInflation_Test(double InitialCPI, double EndingCPI, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Markets.RateOfInflation(InitialCPI, EndingCPI);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Theory]
        [InlineData(0, 4)]
        public void RateOfInflation_DivideByZero_Test(double InitialCPI, double EndingCPI)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Markets.RateOfInflation(InitialCPI, EndingCPI);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
