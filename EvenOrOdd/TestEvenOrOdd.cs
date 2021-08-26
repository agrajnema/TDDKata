using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDKata.EvenOrOdd
{
    public class TestEvenOrOdd
    {
        private readonly EvenOrOdd _evenOrOdd;
        private const string Even = "even";
        private const string Odd = "odd";
        public TestEvenOrOdd()
        {
            _evenOrOdd = new EvenOrOdd();
        }

        [Theory]
        [InlineData(new []{ 1, 2, 3 }, Even )]
        [InlineData(new []{1,2,4}, Odd)]
        public void EvenOrOdd_IsNumberEven(int[] numbers, string expectedResult)
        {
            _evenOrOdd.PrintEvenOrOdd(numbers).Should().Be(expectedResult);
        }
    }
}
