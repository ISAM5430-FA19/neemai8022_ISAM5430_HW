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
            //Console.WriteLine("Enter an Integer:");
            //rConsole.ReadLine();

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i*j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
