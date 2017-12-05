using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,3,4,6,7,8,9,5};

            int minTime = GetMinTime(7,arr);
            int minTime2 = GetMinTime2(7,arr);
            Console.WriteLine("min number is: {0}", minTime);
            Console.WriteLine("min number is: {0}", minTime2);
            Console.Read();
        }

        private static int GetMinTime(int x, int[] arr)
        {
            var index = Array.IndexOf(arr, x);
            int maxIndex = int.MinValue;

            for (int i = 1; i <= arr.Length; i++)
            {
                if (!arr.Contains(i))
                    return -1;
                var iIndex = Array.IndexOf(arr, i);
                if (iIndex > maxIndex)
                    maxIndex = iIndex;
            }
            return maxIndex;
        }

        static int GetMinTime2(int x, int[] arr)
        {
            int _index = Array.FindIndex(arr, r => r.Equals(x));
            if (_index >= 0)
            {
                List<int> _missing = Enumerable.Range(1, x).ToList();
                if (_missing.Count > 0)
                {

                    List<int> _missingIndex = arr.Intersect(_missing).ToList();
                    if (_missingIndex.Count == x)
                    {
                        _index = Array.FindIndex(arr, r => r.Equals(_missingIndex.Last()));
                    }
                    else
                    {
                        _index = -1;
                    }

                }
            }
            else
            {
                _index = -1;
            }

            return _index;

        }
    }
}
