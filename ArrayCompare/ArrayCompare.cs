using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata.ArrayCompare
{
    public class ArrayCompare
    {
        public int CalculateCommonElementsIn2Arrays(int[] array1, int[] array2)
        {
            var result = array1.Intersect(array2);
            return result.Count();
        }
    }
}
