using System;

namespace ITMO.LaboratoryWork_01
{
    class Greeters
    {
        static void Main(string[] args)
        {
            string myName;

            Console.WriteLine("Please inter your name...");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);
            Console.ReadKey();
        }
    }
}