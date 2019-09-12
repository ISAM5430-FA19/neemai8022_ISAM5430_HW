using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the numbers");
            bool flag = false;
            int cur = 0;
            int prev = -1;
            for (int i = 0; i < n; i++)
            {

                cur = Convert.ToInt32(Console.ReadLine());
                if (cur < prev)
                {
                    flag = true;
                    break;
                }
                prev = cur;
            }
            if(flag == true)
            Console.WriteLine("The numbers are not in increasing order");
            else if(flag== false)
            Console.WriteLine("The numbers are in increasing order");
        }
    }
}
