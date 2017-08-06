using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using FluentAssertions;
using RomanNumeralCore;

namespace KataDotNetTests
{
    [TestClass]
    public class RomanNumeralReverseTests
    {
        [Theory]
        [InlineData("I", 1)]
        public void ActualShouldReturnExpectedResult(string input, int expected)
        {
            var actual = RomanNumeral.DeRomanizer(input);
            actual.Should().Be(expected);

        }
    }
}
