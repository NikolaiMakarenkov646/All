using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FrogJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int current = 0;
            int target = 1;
            int distance = 2;
            int steps = CheckFrogSteps(current, target, distance);

            Console.WriteLine("number of steps is: {0}", steps);
            Console.Read();
        }

        private static int CheckFrogSteps(int current, int target, int distance)
        {
            if (current > target)
                throw new Exception("Invalid input");

            if ((target - current) % distance == 0)
                return ((target - current) / distance);

            return ((target - current) / distance) + 1;

        }
    }
}
