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
        public void WhenSubFiveFromFourThenGotTwo()
        {
            MathCalculator calculator = new MathCalculator();

            var result = calculator.Sub(5, 3);

            Assert.Equal(Five - Three, result);
        }

        [Fact]
        public void WhenSubFiveFromFourThenGotOne()
        {
            MathCalculator calculator = new MathCalculator();

            var result = calculator.Sub(4, 5);

            Assert.Equal(Four - Five, result);
        }

        [Fact]
        public void StringSumTestOne(){
            MathCalculator calculator = new MathCalculator();

            var result = calculator.Sum("abc", "cdb");
            Assert.Equal(Convert.ToInt32("abc") + Convert.ToInt32("cdb"), result);
        }

        [Fact]
        public void StringSumTestTwo(){
            MathCalculator calculator = new MathCalculator();

            var result = calculator.Sum("abcd", "efcdb");
            Assert.Equal(Convert.ToInt32("abcd") + Convert.ToInt32("efcdb"), result);
        }
    }
}
