using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1First;

namespace _2Second
{
    class Program
    {
        // ejnkdnqwe
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,4,7,6,6,6,2,0};

            var x = MaxSliceSumFromArr(arr);

        }

        private static int MaxSliceSumFromArr(int[] arr)
        {
            if(arr.Length<=1)
                throw new Exception("Invalid input array");

            int result = 0;
            int increasingSeqCount = 1;
            int decreasingSeqCount = 1;
            int constantSeqCount = 1;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    result = result + increasingSeqCount;
                    increasingSeqCount++;
                    decreasingSeqCount = 1;
                    constantSeqCount = 1;
                } else if (arr[i] > arr[i + 1])
                {
                    result = result + decreasingSeqCount;
                    decreasingSeqCount++;
                    increasingSeqCount = 1;
                    constantSeqCount = 1;
                } else if (arr[i] == arr[i + 1])
                {
                    result = result + constantSeqCount;
                    constantSeqCount++;
                    decreasingSeqCount = 1;
                    increasingSeqCount = 1;
                }
            }
            return result;
        }
    }
}
