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
        [Fact]
        public void Rock1()
        {
            var res = checker.Game(rock, 0);
            Assert.Equal(res, "You win");
        }
    }
}
