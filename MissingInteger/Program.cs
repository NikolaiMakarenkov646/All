using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,3,4,5,};

            int minTime = GetMinInteger( arr);
            Console.WriteLine("min number is: {0}", minTime);
            Console.Read();
        }

        private static int GetMinInteger(int[] arr)
        {
            var arrOredred = arr.Distinct().OrderBy(x => x).ToList();// 1,2,3,4,6

            if (arrOredred[0] <= 0)
                return 1;

            for (int i = 0; i < arrOredred.Count; i++)
            {
                if (arrOredred[i] != i + 1)
                    return i+1;
            }
            return arr.Length+1;
        }
    }
}
