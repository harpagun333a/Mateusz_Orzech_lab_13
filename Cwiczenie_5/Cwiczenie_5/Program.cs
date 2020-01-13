using System;
using System.Threading;

namespace Cwiczenie_5
{
    class Program
    {
        static void Main()
        {
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

// Unhandled exception. System.PlatformNotSupportedException: Operation is not supported on this platform.