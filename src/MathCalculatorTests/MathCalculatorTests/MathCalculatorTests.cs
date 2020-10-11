using System;
using Xunit;

namespace MathCalculatorTests
{
    public class MathCalculatorTests
    {
        //Arrange
        private const int Five = 5;
        const int Three = 3;
        const int Four = 4;
        [Fact]
        public void WhenSumFiveAndThreeThenGotEight()
        {
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

        [Fact]
        public void WhenSubThreeFromFiveThenGotTwo()
        {
            MathCalculator calculator = new MathCalculator();

            var result = calculator.Sub(5, 3);

            Assert.Equal(Five - Three, result);
        }

        [Fact]
        public void WhenSubFourFromFiveThenGotTwo()
        {
            MathCalculator calculator = new MathCalculator();

            var result = calculator.Sub(4, 5);

            Assert.Equal(Four - Five, result);
        }
    }
}
