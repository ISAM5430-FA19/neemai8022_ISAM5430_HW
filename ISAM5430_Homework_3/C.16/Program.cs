using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write("0, ");
                }

                int count = n - i + 1;
                for (int j = 0; j < n - i + 1; j++)
                {
                    Console.Write($"{count--}, ");
                }
            }
            Console.WriteLine();
        }
    }
}
