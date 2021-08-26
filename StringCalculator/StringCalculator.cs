using System;
using System.Linq;

namespace tddkata.StringCalculator
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            var numbers = input.Split(new[] { ",", "\n" }, StringSplitOptions.None);
            return numbers[0].Equals("") ? 0 : numbers.Sum(Convert.ToInt32);
            
        }
    }
}