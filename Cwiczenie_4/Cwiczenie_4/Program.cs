using System;
using System.Threading;

namespace Cwiczenie_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Cwiczenie 4");

            ThreadPool.QueueUserWorkItem(Run);
            ThreadPool.QueueUserWorkItem(Run, 123);
            Console.ReadLine();
        }

        static void Run(object data)
        {
            Console.WriteLine("Hello !! The thread pool! " + data);
        }
    }
}

// Efekt wykonaina:
//
// Cwiczenie 4 
// Hello !! The thread pool!
// Hello !! The thread pool! 123