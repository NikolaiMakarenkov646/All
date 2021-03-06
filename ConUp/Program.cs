﻿using System;
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
            var zz = Registry.CurrentUser.OpenSubKey("Control Panel").OpenSubKey("Desktop").OpenSubKey("Colors");
            var sxsx=zz.Name.Substring(0,zz.Name.IndexOf("\\"));
            var name = zz.Name.Substring(zz.Name.LastIndexOf("\\", StringComparison.Ordinal) + 1);
            var zz2 = Registry.CurrentUser.OpenSubKey("Control Panel").OpenSubKey("Desktop").OpenSubKey("Colors").GetSubKeyNames();

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
