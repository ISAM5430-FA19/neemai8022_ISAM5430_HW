using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int diff;
            int closestvalue = 0;
            int mindiff = int.MaxValue;
            Console.WriteLine("enter an item:");
            int item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter values: ");
            int value = Convert.ToInt32(Console.ReadLine());

            while (value != item)
            {
                
                diff = Math.Abs(value - item);
                if (diff != 0)
                {
                    if (diff < mindiff)
                    {
                        mindiff = diff;
                        closestvalue = value;

                    }
                }
                value = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine($"closest value is {closestvalue}");
        }
    }
}
