using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the count:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < n; i++)
            {
                
                int k = Convert.ToInt32(Console.ReadLine());
                
                sum = sum + k;
            }
            Console.WriteLine(sum);
            double avg = (double)sum / n;
            Console.WriteLine(avg);
        }
    }
}
