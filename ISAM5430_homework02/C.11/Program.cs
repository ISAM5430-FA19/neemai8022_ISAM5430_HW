using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int f = 1;
            while (i < 10)
            {
                f = f * i;
                Console.WriteLine(f);
                i++;
            }
        }
    }
}
