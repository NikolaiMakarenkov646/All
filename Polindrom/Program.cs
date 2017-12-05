using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPolindrom = IsPolindrom("abcdcba");
            Console.WriteLine("The result is {0}",isPolindrom);
        }

        private static bool IsPolindrom(string userInput)
        {
            for (
                int i = 0; i < userInput.Length/2; i++)
            {
                if (userInput[i] != userInput[userInput.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
