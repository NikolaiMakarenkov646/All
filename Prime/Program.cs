using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int number = 0;
            while (counter < 100)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number);
                    counter = counter + number;
                }
                number++;
            }
            Console.WriteLine(counter);

            Console.Read();
        }

        private static bool IsPrime(int candidate)
        {
            if (candidate == 1)
                return false;
            if (candidate == 2)
                return true;
            if (candidate % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(candidate); i++)
            {
                if (candidate % i== 0)
                    return false;
            }
            return true;
        }
    }
}
