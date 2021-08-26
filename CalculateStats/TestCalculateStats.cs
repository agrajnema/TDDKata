using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDKata.CalculateStats
{
    public class TestCalculateStats
    {
        private readonly CalculateStats _calculateStats;

        public TestCalculateStats()
        {
            _calculateStats = new CalculateStats();
        }

        [Theory]
        [InlineData(new [] {1,2,4}, 1)]
        [InlineData(new [] {-1,0,1}, -1)]
        public void Calculate_Stats_Min_Value(int[] numbers, int expectedResult)
        {
            _calculateStats.Calculate(numbers);
            _calculateStats.MinimumValue.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 4 }, 4)]
        [InlineData(new[] { -1, 0, 1 }, 1)]
        public void Calculate_Stats_Max_Value(int[] numbers, int expectedResult)
        {
            _calculateStats.Calculate(numbers);
            _calculateStats.MaximumValue.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 4 },3)]
        [InlineData(new[] { -1, 0, 1 }, 3)]
        public void Calculate_Stats_Total_Numbers(int[] numbers, int expectedResult)
        {
            _calculateStats.Calculate(numbers);
            _calculateStats.TotalNumbers.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, 2)]
        [InlineData(new[] { -1, 0, 1 }, 0)]
        public void Calculate_Stats_Average_Value(int[] numbers, double expectedResult)
        {
            _calculateStats.Calculate(numbers);
            _calculateStats.AverageOfNumbers.Should().Be(expectedResult);
        }

    }
}
