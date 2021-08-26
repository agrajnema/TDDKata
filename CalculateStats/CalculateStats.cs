using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata.CalculateStats
{
    public class CalculateStats
    {
        public int MinimumValue { get; set; }
        public int MaximumValue { get; set; }
        public int TotalNumbers { get; set; }
        public double AverageOfNumbers { get; set; }

        public void Calculate(int[] numbers)
        {
            MinimumValue = numbers.Min();
            MaximumValue = numbers.Max();
            TotalNumbers = numbers.Length;
            AverageOfNumbers = numbers.Average();
        }
    }
}
