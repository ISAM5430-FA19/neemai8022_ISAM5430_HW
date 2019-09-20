using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("'a' = lower left triangle; 'b' = upper left triangle; " +
                                     "'c' = upper right triangle; 'd' = lower right triangle.");
            char t = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the number of lines.");
            int n = Convert.ToInt32(Console.ReadLine());
            int c = n - 1;
           
            if (t == 'a' || t == 'c')
            {
                for (int i = 0; i < n; i++)
                {
                    if (i > 0 && i < n)
                    {
                        Console.Write("\n");
                    }

                    for (int j = 0; j < n; j++)
                    {
                        if (t == 'a')
                        {
                            if (i >= j)
                                Console.Write("*");

                        }

                        if (t == 'c')
                        {
                            if (i <= j)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }

            if (t == 'b')
            {
                for (int i = n; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            if (t == 'd')
            {
                for (int i = n; i > 0; i--)
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < n - i + 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                //Console.WriteLine();
            }
        }
    }
}
