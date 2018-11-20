using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> A = Console.ReadLine().Split(' ').ToList<string>();
            List<string> B = Console.ReadLine().Split(' ').ToList<string>();

            string key = Console.ReadLine();
            string newValue = Console.ReadLine();

            B[A.IndexOf(key)] = newValue;

            for(int i = 0; i < A.Count; i++)
            {
                Console.Write(A[i] + ' ');
            }
            Console.WriteLine();
            for (int i = 0; i < B.Count; i++)
            {
                Console.Write(B[i] + ' ');
            }
            Console.WriteLine();
        }
    }
}
