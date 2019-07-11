using System;
using Xunit;

namespace Finance.Tests.Banking
{
    public class SimpleInterest
    {
        [Theory]
        [InlineData(100.0,5, 60, 300)]
        [InlineData(1000.0, 0.5, 180, 900.0)]
        [InlineData(1000.0, 0, 180, 0)]
        [InlineData(1000.0, 0.5, 0, 0)]
        [InlineData(0, 0.5, 180, 0)]
        public void SimpleInterestio__Test(double principal, double rate, double time, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Banking.SimpleInterest(principal, rate, time);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
