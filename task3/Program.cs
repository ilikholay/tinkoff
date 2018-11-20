using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(Console.ReadLine());

            bool finish = false;
            while (!finish)
            {
                finish = true;
                for (int i = 0; i < strBuilder.Length - 1; i++)
                {
                    if (strBuilder[i] == strBuilder[i + 1])
                    {
                        strBuilder.Remove(i, 2);
                        finish = false;
                        break;
                    }
                }
            }
            Console.WriteLine(strBuilder.ToString());
        }
    }
}
