using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata.EvenOrOdd
{
    public class EvenOrOdd
    {
        public int Sum { get; set; }

        private int CalculateSum(int[] numbers)
        {
            return numbers.Sum();
        }

        private bool IsSumEven()
        {
            return (Sum % 2 == 0);
        }

        public string PrintEvenOrOdd(int[] numbers)
        {
            Sum = CalculateSum(numbers);
            var isSumEven = IsSumEven();
            return isSumEven ? "even" : "odd";
        }
    }
}
