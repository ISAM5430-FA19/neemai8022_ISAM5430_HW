using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int avg=0;
            int sum = 0;
            Console.WriteLine("Enter scores:");
            int score=Convert.ToInt32(Console.ReadLine());
            
            while (score > 0 && score <= 100)
            {
                sum = sum + score;                           
                score = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            avg = sum / i;
            Console.WriteLine(avg);
        }
    }
}
