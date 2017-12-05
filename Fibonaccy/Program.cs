using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaccy
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sum2 = Rec(4);
            var sum = Fibonacci(4);

            Console.WriteLine("The result {0}",sum);
        }

        private static int Fibonacci(int i)
        {
            if (i <= 1)
                return i;
            var temp = Fibonacci(i - 1);
            var temp2 = Fibonacci(i - 2);
            return temp + temp2;
        }

        private static int Rec(int i)
        {
            if (i == 0)
                return 1;
            i = Rec(i - 1);
            i = i * 2;
            return i;
        }
    }
}
