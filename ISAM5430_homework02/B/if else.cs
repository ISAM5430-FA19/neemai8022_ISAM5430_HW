using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class ifelse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a First Number");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Second Number");
            int b = Int32.Parse(Console.ReadLine());

            if(a == b)
            {
                Console.WriteLine("Both are same");
            } else if(a > b)
            {
                Console.WriteLine("A is greater");
            } else
            {
                Console.WriteLine("B is greater");

            }

        }
    }
}
