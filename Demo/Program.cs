using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new a();
            Type objType =obj.GetType();
            Type x = typeof(a);
        }
    }

    class a
    {
        public int num1 { get; set; }
    }
}
