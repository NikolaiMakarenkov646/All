using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Peaks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
            var minBlocks = GetMaximumOfBlocks(arr);
            Console.Read();
        }

        private static int GetMaximumOfBlocks(int[] arr)
        {
            var allPicks = GetAllIndexesPeaks(arr);
            int max = int.MinValue;
            for (int i = 1; i <= Math.Min(Math.Sqrt(arr.Length),allPicks.Count); i++)
            {
                if(arr.Length % i != 0)
                    continue;
                List<List<int>> block = GetBlockArrays(arr, i);
                var isValidBlock= block.All(oneBlock => oneBlock.Any(elementInBlock => allPicks.Any(peak => peak == elementInBlock)));
                if (i > max)
                    max = i;
            }
            return max;
        }

        private static List<List<int>> GetBlockArrays(int[] arr, int numberOfBlocks)
        {
            List<List<int>> result = new List<List<int>>();

            for (int j = 0; j < numberOfBlocks; j++)
            {
                var subList = SubArray(arr, j * (arr.Length / numberOfBlocks), arr.Length / numberOfBlocks);
                result.Add(subList);
            }
            return result;
        }

        public static List<T> SubArray<T>(T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result.ToList();
        }

        private static List<int> GetAllIndexesPeaks(int[] arr)
        {
            var resultOfIndex = new List<int>();
            if (arr[0] > arr[1])
                resultOfIndex.Add(0);
            if (arr[arr.Length - 1] > arr[arr.Length - 2])
                resultOfIndex.Add(arr.Length - 1);
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    resultOfIndex.Add(i);
            }

            return resultOfIndex;
        }
    }
}
