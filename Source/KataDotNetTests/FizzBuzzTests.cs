using System;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;
using FizzBuzzCore;
using FluentAssertions;

namespace KataDotNetTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1, 1)]


        public void FizzBuzzShouldReturnExpectedResult(int input, string expected)
        {
            var actual = FizzBuzz.FizzBuzzer(input);
            actual.Should().Be(expected);

        }
    }
}
