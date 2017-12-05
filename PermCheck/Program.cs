using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,3,4,5,6,2,9,8,7};
            
            bool isSuccess = IsCorrectArray(arr);
            bool isSuccess2 = IsCorrectArray2(arr);
            Console.WriteLine("Result: {0}", isSuccess);
            Console.Read();
        }

        public static bool IsCorrectArray(int[] arr)
        {
            var orderedArray = arr.OrderBy(x => x).ToArray();

            for (int i = 0; i < orderedArray.Length; i++)
            {
                if ((orderedArray[i]-1) != i)
                    return false;
            }

            return true;
        }

        public static bool IsCorrectArray2(int[] arr)
        {
            bool[] boolArray = new bool[arr.Length];

            foreach (int value in arr)
            {
                if (value > arr.Length || value < 1)
                    return false;
                if (boolArray[value - 1] == true)
                    return false;
                
                boolArray[value - 1] = true;
            }
            return true;
        }
    }
}
