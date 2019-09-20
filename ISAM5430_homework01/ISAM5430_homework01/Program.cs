using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAM5430_homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            string input = Console.ReadLine(); //returns a string
            int num1 = int.Parse(input);
            Console.WriteLine("Enter number 2");
            input = Console.ReadLine(); //reads a line from the keyboard and assigns to the input variable
            int num2 = Convert.ToInt32(input);
            Console.WriteLine("Enter the operator: (+,-,/,*)");
            string op = Console.ReadLine();

            if(op == "+")
            {
                int sum;
                sum = num1 + num2;
                Console.WriteLine(sum);
            }
            if(op == "-")
            {
                int sub;
                sub = num1 - num2;
                Console.WriteLine(sub);
            }
           if(op == "/")
            {
                int div;
                div = num1 + num2;
                Console.WriteLine(div);
            }
           if(op == "*")
            {
                int mult;
                mult = num1 + num2;
                Console.WriteLine(mult);
            }

        }
    }
}
