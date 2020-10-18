using System.Reflection;
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
        const string rock = "rock";
        const string paper = "paper";
        const string scissors = "scissors";
        [Fact]
        public void Rock1()
        {
            var res = checker.Game(rock, 0);
            Assert.Equal("You lose", res);
        }
        [Fact]
        public void Rock2()
        {
            var res = checker.Game(rock, 1);
            Assert.Equal("You win", res);
        }
        [Fact]
        public void Rock3()
        {
            var res = checker.Game(rock, 2);
            Assert.Equal("Draw", res);
        }



        [Fact]
        public void Paper1()
        {
            var res = checker.Game(paper, 1);
            Assert.Equal("You lose", res);
        }
    }
}
