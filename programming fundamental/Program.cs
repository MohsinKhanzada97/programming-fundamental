using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_fundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int exponent = 0;
            int sum = 1;
            Console.WriteLine("Enter Number:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Exponent:");
            exponent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < exponent; i++)
            {
                sum = sum * num;
            }

            Console.Write("The Exponent Of " + num + " to " + exponent + " is:" + sum);
            Console.ReadKey();
        }
    }
}
