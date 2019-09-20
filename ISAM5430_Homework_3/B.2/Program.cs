using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int curr = 0;
            int prev = 0;
            int sum = 0;
            Console.WriteLine("enter a no:");
            curr=Convert.ToInt32(Console.ReadLine());
            while (curr != prev)
            {
                sum = sum + curr;
                
                prev = curr;
                curr = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
