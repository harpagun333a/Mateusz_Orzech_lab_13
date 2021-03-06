﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_5_dot_net_framework
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Cwiczenie 5");
            Func<string, int> method = Do;
            IAsyncResult cookie = method.BeginInvoke("test", null, null);
            int result = method.EndInvoke(cookie);
            Console.WriteLine("String length is: " + result);
        }

        static int Do(string s) 
        { 
            return s.Length; 
        }
    }
}

// Efekt wykonania
//
// Cwiczenie 5
// String length is: 4 