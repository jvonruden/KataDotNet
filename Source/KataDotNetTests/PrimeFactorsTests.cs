using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using FluentAssertions;
using PrimeFactorsCore;

namespace KataDotNetTests
{
    [TestClass]
    public class PrimeFactorsTests
    {
        [Theory]
        [InlineData(2, new int[] {2})]
        public void ActualShouldReturnExpectedResult(int input, int[] expected)
        {
            var actual = PrimeFactors.Factorize(input);
            actual.ShouldBeEquivalentTo(expected);

        }
    }
}
