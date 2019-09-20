using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int prev = 0;
            Console.WriteLine("Enter the value:");
            int curr = Convert.ToInt32(Console.ReadLine());
            while (curr > prev)
            {
                prev = curr;
                curr = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(prev);
        }
    }
}
