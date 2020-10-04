using System;
using Xunit;

namespace MathCalculatorTests
{
    public class MathCalculatorTests
    {
        [Fact]
        public void WhenSumFiveAndThreeThenGotEight()
        {
            //Arrange
            const int Five = 5;
            const int Three = 3;
            MathCalculator calculator = new MathCalculator();

            //Act
            var r1 = calculator.Sum(3, 5);
            var r2 = calculator.Sub(5, 3);
            var r3 = calculator.Mul(5, 3);
            var r4 = calculator.Dev(5, 3);

            //Assert
            Assert.Equal(Five + Three, r1);
            Assert.Equal(Five - Three, r2);
            Assert.Equal(Five * Three, r3);
            Assert.Equal(Five / Three, r4);
        }
    }
}
