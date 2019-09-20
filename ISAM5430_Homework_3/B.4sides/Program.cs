using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._4sides
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;  
            int x = 0;
            int y = 0;
            int z = 0;
            
            while (true)
            {
                Console.WriteLine("Enter number:");
                string s = "";
                s = Console.ReadLine();
                int n = Convert.ToInt32(s);
                i++;
                if (s == null)
                {
                    break;
                }
                if (n <= 0)
                {
                    Console.WriteLine("Cannot enter zero or negative values:");
                    break;
                }
                if (i == 1)
                {
                    x = n;
                }
                if (i == 2)
                {
                    y = n;
                }
                if (i == 3)
                {
                    z = n;
                    if (x + y > z)
                    {
                        Console.WriteLine("valid triangle");
                    }
                    else if (x + y > z)
                    {
                        Console.WriteLine("valid triangle");
                    }
                    break;
                }
            }
        }
    }
}
