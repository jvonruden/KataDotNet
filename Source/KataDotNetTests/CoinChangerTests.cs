using CoinChangerCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using FluentAssertions;

namespace KataDotNetTests
{
    [TestClass]
    public class CoinChangerTests
    {
        // [quarters, dime, nickels, pennies]
        [Theory]
        [InlineData(4, new int[] {0,0,0,4})]
        public void ActualShouldReturnExpectedResult(int input, int[] expected)
        {
            var actual = CoinChanger.Changer(input);
            actual.ShouldBeEquivalentTo(expected);

        }
    }
}
