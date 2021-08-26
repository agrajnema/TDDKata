using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDKata.FizzBuzz
{
    
    public class TestFizzBuzz
    {
        private readonly FizzBuzz _fizzBuzz;

        public TestFizzBuzz()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Theory]
        [InlineData(new [] {1,2,3}, "Fizz")]
        public void Print_Last_Number_Text(int[] numbers, string expectedResult)
        {
           // _fizzBuzz.FizzBuzzGame(numbers.Length).Should().Be(expectedResult);

        }
        
    }

}
