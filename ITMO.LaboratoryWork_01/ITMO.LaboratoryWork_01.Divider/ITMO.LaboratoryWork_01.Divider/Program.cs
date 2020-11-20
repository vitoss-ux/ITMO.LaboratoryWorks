using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.LaboratoryWork_01.Divider
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Please inter the first integer");
            string temp = Console.ReadLine();
            int i = Int32.Parse(temp);

            Console.WriteLine("Please inter the second integer");
            temp = Console.ReadLine();
            int j = Int32.Parse(temp);

            int k = i / j;
            Console.WriteLine(k);
            Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown {0}", e);
                Console.ReadKey();
            }
        }
    }
}
