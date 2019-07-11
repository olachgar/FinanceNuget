using System;
using Xunit;

namespace Finance.Tests.General
{
    public class RuleOf72
    {
        [Fact]
        public void RuleOf72_1p215_Test()
        {
            // Arrange
            double rate = 1.215;

            // Act
            var actualResult = Finance.General.RuleOf72(rate);
            var expectedResult = Math.Round(59.2592592592593, 5);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Fact]
        public void RuleOf72_1_Test()
        {
            // Arrange
            double rate = 1;

            // Act
            var actualResult = Finance.General.RuleOf72(rate);
            var expectedResult = 72;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void RuleOf72_12_Test()
        {
            // Arrange
            double rate = 12;

            // Act
            var actualResult = Finance.General.RuleOf72(rate);
            var expectedResult = 6;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
