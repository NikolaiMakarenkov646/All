using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3,4,4,6,1,4,4};
            int numberOfCounters = 5;
            int[] minTime = GetAllCounters(numberOfCounters, arr);
            Console.WriteLine("min number is: {0}", minTime);
            Console.Read();
        }

        private static int[] GetAllCounters(int numberOfCounters, int[] arr)
        {
            int[] totalSum = new int[numberOfCounters];

            foreach (var currentValue in arr)
            {
                if (1 <= currentValue && currentValue < numberOfCounters)
                    totalSum[currentValue-1]++;
                else if (currentValue > numberOfCounters)
                {
                    int max = totalSum.Max();
                    int[] totalSum2 = totalSum.Select(x => x=max).ToArray();
                    totalSum = totalSum2;
                }
            }
            return totalSum;
        } 
    }
}  