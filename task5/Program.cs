using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            List<string> A = a.Split(' ').ToList<string>();
            List<string> B = b.Split(' ').ToList<string>();

            for (int i = 0; i < B.Count; i++)
            {
                if (!A.Contains(B[i]))
                    Console.Write(B[i] + ' ');
            }
            Console.WriteLine();

            for (int i = 0; i < A.Count; i++)
            {
                if (!B.Contains(A[i]))
                    Console.Write(A[i] + ' ');
            }
            Console.WriteLine();


        }
    }
}
