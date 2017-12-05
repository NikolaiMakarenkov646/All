using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPerimeterRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = MaxSliceSumFromArr(30);
            Console.WriteLine("Min is: {0}", x);
            Console.Read();
        }

        private static int MaxSliceSumFromArr(int area)
        {
            int min = int.MaxValue;
            if (area <= 0)
                return 0;
            for (int i = 1; i < Math.Sqrt(area); i++)
            {
                if (area % i == 0)
                    min = Math.Min(min, 2 * (i + area / i));
            }

            return min;
        }
    }
}
