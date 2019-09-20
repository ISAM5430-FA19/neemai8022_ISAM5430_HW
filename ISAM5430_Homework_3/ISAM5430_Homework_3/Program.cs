using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAM5430_Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n;
            Console.WriteLine("Enter an Integer:");
            Console.ReadLine();

            for(int i = 0; i <= 4; i++)
            {
                for(int j = 0; j <= 4; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
