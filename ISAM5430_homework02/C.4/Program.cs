using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("positive and odd number");
            for (i = 1; i <= 20; i++)
            {
                if (i > 0)
                {
                    if(i%2==1 && i % 3 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
