using System;
using System.Threading;

namespace Cwiczenie_2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cwiczenie 2");

            new Thread(Run).Start();
        }

        static void Run()
        {
            try
            {
                throw null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception!");
            }
        }
    }
}

// Należy zastosować metodę z zadania 2, ponieważ nie przerywa ona działania całego programu w wypadku wysypania się jednego wątku