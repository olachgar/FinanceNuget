using System;
using Xunit;

namespace Finance.Tests.General
{
    public class NumberOfPeriods
    {
        [Theory]
        [InlineData(2000, 1500, 7.5, 0)] //3.9779
        //[InlineData(2, 4, 5, -14.2067)]
        //[InlineData(2.0, 1.0, 10.0, 7.2725)]
        public void NumberOfPeriods_Test(double futureValue, double presentValue, double ratePerPeriod, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.NumberOfPeriods(futureValue, presentValue, ratePerPeriod);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
