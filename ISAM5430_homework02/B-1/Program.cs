using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a First Number");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Second Number");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Third Number");
            int c = Int32.Parse(Console.ReadLine());

            if (a > b && a < c || a > c && a < b)
            {
                Console.WriteLine("A is in middle");
            }
            if (b < a && b > c || b > a && b < c)
            {
                Console.WriteLine("B is in middle");
            }
            if (c > a && c < b || c < a && c > b)
            {
                Console.WriteLine("C is in middle");
            }
        }
    }
}
