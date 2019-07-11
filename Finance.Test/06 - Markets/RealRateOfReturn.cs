using System;
using Xunit;

namespace Finance.Tests.Markets
{
    public class RealRateOfReturn
    {

        [Theory]
        [InlineData(1, 0.4, 0.59761)]
        [InlineData(1, 1, 0)]
        [InlineData(20000, 3, 19414.56311)]
        [InlineData(1019.420, 1.030, 1008.00752)]
        public void RealRateOfReturn_Test(double nominalRate, double inflationRate, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Markets.RealRateOfReturn(nominalRate, inflationRate);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(2, -100)]
        [InlineData(0, -100)]
        public void RealRateOfReturn_DivideByZero_Test(double nominalRate, double inflationRate)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Markets.RealRateOfReturn(nominalRate, inflationRate);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
