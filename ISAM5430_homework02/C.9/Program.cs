using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            //while (true)
            while(i>0)
            {
                Console.WriteLine(i);
                //if (i == 0) break;
                i = i / 2;
            }

        }
    }
}
