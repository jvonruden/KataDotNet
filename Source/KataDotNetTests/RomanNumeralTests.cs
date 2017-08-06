using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using FluentAssertions;
using RomanNumeralCore;

namespace KataDotNetTests
{
    [TestClass]
    public class RomanNumeralTests
    {
        [Theory]
        [InlineData(1, "I")]
        public void ActualShouldReturnExpectedResult(int input, string expected)
        {
            var actual = RomanNumeral.Romanizer(input);
            actual.Should().Be(expected);

        }
    }
}
