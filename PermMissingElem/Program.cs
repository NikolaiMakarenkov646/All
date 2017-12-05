using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {2,3,1,5,4,7,8};

            int totalValue = arr.Sum() - arr.Max();
            int indexTotalValue = 0;

            if ((arr.Length ) % 2 != 0)
            {
                indexTotalValue += arr[arr.Length / 2 + 1];
            }

            indexTotalValue += (1 + arr.Length) * (arr.Length / 2);

            Console.WriteLine(" The missed number is: {0}", indexTotalValue -totalValue);
            Console.WriteLine(" The missed number is: {0}", xor(arr));

            Console.Read();
        }

        static int xor(int[] arr)
        {
            int result = 0;

            foreach (int elem in arr)
            {
                result ^= elem;
            }

            for (int i = 1; i <= arr.Length + 1; i++)
            {
                result ^= i;
            }
            return result;
        }
    }
}
