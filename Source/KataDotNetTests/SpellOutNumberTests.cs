using CoinChangerCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using FluentAssertions;
using SpellOutNumberCore;

namespace KataDotNetTests
{
    [TestClass]
    public class SpellOutNumberTests
    {
        [Theory]
        [InlineData(1, "one")]
        public void ActualShouldReturnExpectedResult(int input, string expected)
        {
            var actual = SpellOutNumber.SpellItOut(input);
            actual.ShouldBeEquivalentTo(expected);

        }
    }
}
