using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no.");
            
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1;i<=n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
