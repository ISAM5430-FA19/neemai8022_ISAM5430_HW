using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c, n, i;
            n=25;
            {
                Console.WriteLine("Fibonacci Series:");
                Console.WriteLine(a+" ");
                Console.WriteLine(b + "");

                for (i = 0; i < n-2; ++i)
                {
                    c = a + b;
                    Console.WriteLine(c + "");
                    a = b;
                    b = c;
                }
            }
        }
    }
}
