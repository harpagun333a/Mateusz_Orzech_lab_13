using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cwiczenie_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Cwiczenie 3");
            Task.Factory.StartNew(Run);
        }

        static void Run()
        {
            Console.WriteLine("Hello !! The thread pool!");
        }
    }
}

// Nic się nie stało. Co ciekawe: po dadaniu linijki z napisaniem "ćwiczenie 3" na wyjściu otrzymano też napis "Hello !! The thread pool!"