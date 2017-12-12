using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ConUp
{
    class Program
    {
        static void Main(string[] args)
        {
            var registryKey = Registry.ClassesRoot.GetValue("EditFlags");
            var registryKey2 = Registry.ClassesRoot.GetValue("zzz");
            var zz = Registry.CurrentUser.OpenSubKey("Control Panel").OpenSubKey("Desktop").OpenSubKey("Colors").GetValueNames();
            var zz2 = Registry.CurrentUser.OpenSubKey("Control Panel").OpenSubKey("Desktop").OpenSubKey("Colors")
                .GetValue("Hilight");

            string x = FindAtRegistry("EditFlags");
            Console.ReadLine();
        }

        private static string FindAtRegistry(string str)
        {
            var registryKey = Registry.LocalMachine;
            var allNames = registryKey.GetSubKeyNames();
            string result = allNames.ToList().Find(x => x == str);
            return result;
        }
    }
}
