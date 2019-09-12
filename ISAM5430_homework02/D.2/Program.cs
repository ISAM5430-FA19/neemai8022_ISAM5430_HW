using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the numbers");
            int count = 0;
            for (int i = 0; i < n; i++)
            {

                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
