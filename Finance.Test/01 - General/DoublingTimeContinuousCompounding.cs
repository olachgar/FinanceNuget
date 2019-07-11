using System;
using Xunit;

namespace Finance.Tests.General
{
    public class DoublingTimeContinuousCompounding
    {
        [Theory]
        [InlineData(5, 13.86294)]
        [InlineData(10, 6.93147)]
        [InlineData(15, 4.62098)]
        [InlineData(20, 3.46574)]
        [InlineData(25, 2.77259)]
        public void DoublingTimeContinuousCompounding_Test(double rate, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.DoublingTimeContinuousCompounding(rate);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0)]
        public void DoublingTimeContinuousCompounding_DivideByZero_Test(double rate)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.DoublingTimeContinuousCompounding(rate);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
