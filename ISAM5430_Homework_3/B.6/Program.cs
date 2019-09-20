using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 0;
            int reverse = 0;
            Console.WriteLine("Enter Positive Integer:");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                digit = n % 10;
                reverse = reverse * 10 + digit;
                n = n / 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
