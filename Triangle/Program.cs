using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {10,2,5,1,8,20};

            bool isTriangle = IsTriangle(arr);
            Console.WriteLine("min number is: {0}", isTriangle);
            Console.Read();
        }

        private static bool IsTriangle(int[] arr)
        {
            if(arr.Length< 3)
                throw  new Exception("Invalid input");

            var arrOrdered = arr.OrderBy(x => x).ToArray();

            for (int i = 0; i < arrOrdered.Length; i++)
            {
                if (arrOrdered[i] + arrOrdered[i + 1] > arrOrdered[i + 2])
                {
                    Console.WriteLine("numbers are: {0}, {1}, {2}", arrOrdered[i], arrOrdered[i+1], arrOrdered[i+2]);
                    Console.Read();

                    return true;
                }
            }
            return false;
        }
    }
}
