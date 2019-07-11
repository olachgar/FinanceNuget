using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class GeometricMeanReturn
    {
        [Theory]
        [InlineData(500.0)]
        public void GeometricMeanReturn_Test(double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.GeometricMeanReturn();

            // Assert
            //Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


    }
}
