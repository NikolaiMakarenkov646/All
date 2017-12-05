using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesting
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[]{ '(', '(', ')', '(', '(', ')', ')', '(', ')', ')', };

            bool isNested = IsNested(arr);
            Console.WriteLine("Result: {0}", isNested);
            Console.Read();
        }
        
        private static bool IsNested(char[] arr)
        {
            var counter = 0;
            foreach (var current in arr)
            {
                if (current == '(')
                {
                    counter++;
                    continue;
                }
                if (counter == 0)
                    return false;
                counter--;
            }
            return counter == 0;
        }
    }
}
