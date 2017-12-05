using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDiv
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = GetDivisibleIntegers2(6, 11, 2);
            var countNumbers = GetDivisibleIntegers(6, 11, 2);
            if (numbers.Count == 0)
            {
                Console.WriteLine("divisible number is: 0");
                Console.Read();
            }
            foreach (var currentNumber in numbers)
            {
                Console.WriteLine("divisible number is: {0}", currentNumber);
            }
            Console.WriteLine("number of divisibles are:  {0}", numbers.Count);

            Console.Read();
        }

        private static int GetDivisibleIntegers(int first, int last, int k)
        {
            if (first < 1 || k > last)
                return 0;

            int lastWithoudModule = (last - last % k);
            int res = (lastWithoudModule - first) / k + 1;
            return res;
        }
        private static List<int> GetDivisibleIntegers2(int first, int last, int k)
        {
            List<int> result = new List<int>();

            if (first > last || k < 1)
                throw new Exception("Aout of range");

            if (first == last)
            {
                if (first % k == 0)
                {
                    result.Add(first);
                    return result;
                }
                return result;
            }

            for (int i = first; i <= last; i++)
            {
                if(i%k == 0)
                    result.Add(i);
            }
            return result;
        }
    }
}
