using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsDistinct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -5,-3,-1,0,3,6};

            int minNumber = GetDistinctCount(arr);
            Console.WriteLine("min number is: {0}", minNumber);
            Console.Read();
        }

        private static int GetDistinctCount(int[] arr)
        {
            return arr.ToList().ConvertAll(x => Math.Abs(x)).Distinct().Count();
        }
    }
}
