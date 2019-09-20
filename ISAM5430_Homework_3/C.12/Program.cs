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
            //Console.WriteLine("enter a number:");
            //Console.ReadLine();

            for(int i = 2; i<= 100; i++)
            {
                int counter = 0;
                for(int j = 1; j <= 100; j++)
                {
                    if(i % j == 0)
                    {
                        counter++;
                        if (counter > 3) break;
                    }
                    
                }
                if(counter == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
