using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {3,1,2,4,3,8,3};

            int minNumber = GetMinNumber(arr);
            Console.WriteLine("min number is: {0}", minNumber);
            Console.Read();
        }

        public static int GetMinNumber(int[] arr)
        {
            var leftSum = arr[0];
            var rightSum = arr.Skip(1).Sum();
            int result = Int32.MaxValue;
            
            for (int i = 0; i < arr.Length; i++)
            {
                int value = Math.Abs(leftSum - rightSum);

                if (value < result)
                    result = value;
                leftSum += arr[i];
                rightSum -= arr[i];
            }

            return result;
        }
    }
}
