using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 0,1,1, };

            Dictionary<int, List<int>> dic = GetAllPassingPairs(arr);
            GetAllPassingPairs2(arr);
            Console.WriteLine("All passings pairs are: {0}", dic.Values.SelectMany(x => x).Count());

            Console.Read();
        }

        private static Dictionary<int, List<int>> GetAllPassingPairs(int[] arr)
        {
            if (arr.Length <= 1)
                throw new Exception("Invalid input array");
            var dic = new Dictionary<int, List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    dic.Add(i, new List<int>());
                    continue;
                }

                foreach (var current in dic.Values)
                {
                    current.Add(i);
                }
            }

            return dic;
        }

        static int GetAllPassingPairs2(int[] A)
        {
            int countZero = 0;
            int passingCarCount = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    countZero++;
                }
                else
                {
                    if (countZero > 0 && passingCarCount <= 1000000000)
                    {
                        passingCarCount = passingCarCount + countZero;
                    }
                    else if (passingCarCount > 1000000000)
                    {
                        return -1;
                    }
                }

            }
            return passingCarCount;
        }
    }
}
