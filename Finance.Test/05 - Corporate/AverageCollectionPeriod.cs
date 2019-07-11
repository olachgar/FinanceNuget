using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class AverageCollectionPeriod
    {   
        [Fact]
        public void AvgCollectionPeriod_8_365orYear_Test()
        {
            // Arrange
            double receivablesTurnoverRatio = 8;

            // Act
            var actualResult = Finance.Corporate.AvgCollectionPeriod(receivablesTurnoverRatio);
            var expectedResult = 45.625;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void AvgCollectionPeriod_0_365orYear_Test()
        {
            // Arrange
            double receivablesTurnoverRatio = 0;

            // Act
            Action actualResult = () => Finance.Corporate.AvgCollectionPeriod(receivablesTurnoverRatio);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void AvgCollectionPeriod_429_180_Test()
        {
            // Arrange
            double receivablesTurnoverRatio = 4.29;
            int timePeriod = 180;

            // Act
            var actualResult = Finance.Corporate.AvgCollectionPeriod(receivablesTurnoverRatio, timePeriod);
            var expectedResult = 41.95804195804196;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
