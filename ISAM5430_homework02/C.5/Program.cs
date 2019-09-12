using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n < 10)
            {
                int square;
                square = n * n;

                if(square/10 != 0)
                {
                    Console.WriteLine(square); 
                }
                n++;
            }
        }
    }
}
