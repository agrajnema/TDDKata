using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDKata.ArrayCompare
{
    public class TestArrayCompare
    {
        private readonly ArrayCompare _arrayCompare;

        public TestArrayCompare()
        {
            _arrayCompare = new ArrayCompare();
        }

        [Theory]
        [InlineData(new [] {1,2,3}, new [] {2,5,7}, 1)]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 2, 4, 5, 7 }, 2)]
        [InlineData(new[] { 1, 2, 3 }, new[] { 4, 5, 7 }, 0)]
        public void Test_Common_Elements_In_Both_Arrays(int[] array1, int[] array2, int expectedResult)
        {
            _arrayCompare.CalculateCommonElementsIn2Arrays(array1, array2).Should().Be(expectedResult);
        }
    }
}
