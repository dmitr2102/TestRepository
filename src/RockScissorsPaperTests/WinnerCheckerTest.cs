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
        const string rock = "rock";
        const string paper = "paper";
        const string scissors = "scissors";
        [Fact]
        public void Rock1()
        {
            var res = checker.Game(rock, 0);
            Assert.Equal(res, "You win");
        }

        [Fact]
        public void Paper1(){
            var res = checker.Game("paper", 1);
            Assert.Equal(res, "You lose");
        }
    }
}
