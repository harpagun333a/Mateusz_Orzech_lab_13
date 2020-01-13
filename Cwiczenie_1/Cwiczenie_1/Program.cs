using System;
using System.Threading;

namespace Cwiczenie_1
{
    class Program
    {
        public static void Main()
        {
            try
            {
                new Thread(Run).Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception!");
            }
        }

        static void Run() 
        { 
            throw null; 
        }
    }
}

// Unhandled exception
