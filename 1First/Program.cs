using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _1First
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 195378678;
            int num2 = 78;

            Console.WriteLine(solution(num,num2));
            Console.Read();
        }

        public static int solution(int A, int B)
        {
            if(string.IsNullOrEmpty(A.ToString()) || string.IsNullOrEmpty(B.ToString()))
                throw new Exception("Invalid input");

            return A.ToString().IndexOf(B.ToString(), StringComparison.Ordinal);
        }
    }
}
