using Xunit;
using FluentAssertions;

namespace tddkata.StringCalculator
{
    public class TestStringCalculator
    {
        private readonly StringCalculator _stringCalculator;

        public TestStringCalculator()
        {
            _stringCalculator = new StringCalculator();
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]
        [InlineData("1,2", 3)]
        [InlineData("1\n2,3", 6)]
        public void Add_Numbers_InString_ReturnSum(string input, int expectedResult){
            _stringCalculator.Add(input).Should().Be(expectedResult);
        }
    }
}