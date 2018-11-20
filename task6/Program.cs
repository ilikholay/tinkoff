using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if ((i + 1) % 3 != 0 && (i + 1) % 5 != 0)
                {
                    Console.WriteLine(i + 1);
                    continue;
                }
                if ((i + 1) % 3 == 0)
                    Console.Write("Fizz");
                if ((i + 1) % 5 == 0)
                    Console.Write("Buzz");
                Console.WriteLine();
            }
        }
    }
}
