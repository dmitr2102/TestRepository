using System;
using Xunit;
using RockScissorsPaperLib;

namespace RockScissorsPaperTests
{
    public class WinnerCheckerTest
    {
        private WinnerChecker checker = new WinnerChecker();
        // Random rnd = new Random();
        //0 == paper
        //1 == scissors
        //2 == rock
        enum t {paper = 0, scissors = 1, rock = 2, lizard}

        [Fact]
        public void Rock1()
        {
            var res = checker.Game((int)t.rock, (int)t.paper);
            Assert.Equal("You lose", res);
        }
        [Fact]
        public void Rock2()
        {
            var res = checker.Game((int)t.rock, (int)t.scissors);
            Assert.Equal("You win", res);
        }
        [Fact]
        public void Rock3()
        {
            var res = checker.Game((int)t.rock, (int)t.rock);
            Assert.Equal("Draw", res);
        }



        [Fact]
        public void Paper1()
        {
            var res = checker.Game((int)t.paper, (int)t.paper);
            Assert.Equal("Draw", res);
        }

        [Fact]
        public void Paper2()
        {
            var res = checker.Game((int)t.paper, (int)t.scissors);
            Assert.Equal("You lose", res);
        }

        [Fact]
        public void Paper3()
        {
            var res = checker.Game((int)t.paper, (int)t.rock);
            Assert.Equal("You win", res);
        }

        [Fact]
        public void Sciccors1()
        {
            var res = checker.Game((int)t.scissors, (int)t.paper);
            Assert.Equal("You win", res);
        }

        [Fact]
        public void Scissors2()
        {
            var res = checker.Game((int)t.scissors, (int)t.scissors);
            Assert.Equal("Draw", res);
        }

        [Fact]
        public void Scissors3()
        {
            var res = checker.Game((int)t.scissors, (int)t.rock);
            Assert.Equal("You lose", res);
        }
    }
}
