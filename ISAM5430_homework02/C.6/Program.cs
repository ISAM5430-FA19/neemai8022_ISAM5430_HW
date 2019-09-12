using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (i = 1; i < 100; i++)
            {
                if(i%3 !=0 && i%5 != 0)
                {
                    Console.WriteLine(i);
                }
                if(i%3 ==0 && i%5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
