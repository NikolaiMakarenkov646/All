using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSliceSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,-2,-3,4,-5,10 };

            var x = MaxSliceSumFromArr( arr);
            Console.WriteLine("Max is: {0}", x);
            Console.Read();
        }

        private static int MaxSliceSumFromArr(int[] arr)
        {
            var max_ending = -1000000;
            var result = -1000000;
            foreach (var a in arr)
            {
                max_ending = Math.Max(a, max_ending + a);
                result = Math.Max(result, max_ending);
            }

            return result;
        }
    }
}
