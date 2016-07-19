using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Let's guess the square root of numbers**");
            Console.WriteLine("Please enter a positive number: ");
            string userNumInput = Console.ReadLine();
            double number = double.Parse(userNumInput);
            Console.WriteLine("Please enter an error limit:  ");
            string userErrLimitInput = Console.ReadLine();
            double errorlimit = double.Parse(userErrLimitInput);

            // double result = SquareRootUtilities.ComputeSquareRoot(number, errorlimit);
            SquareRootInfo mySqrt = new SquareRootInfo(errorlimit);
            double result = mySqrt.ComputeSquareRoot(number);

            Console.WriteLine("The result is {0}", result);
            Console.ReadLine();
            
        }
    }
}
