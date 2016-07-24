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
            //Console.WriteLine("Please enter a positive number: ");
            //string userNumInput = Console.ReadLine();
            //double number = double.Parse(userNumInput);
            Console.WriteLine("Please enter an error limit:  ");
            string userErrLimitInput = Console.ReadLine();
            double errorlimit = double.Parse(userErrLimitInput);

            //Instantiating Objects
            MySquare myHeronSqrt = new MySquare(errorlimit);
            StdSqrt myStandardSqrt = new StdSqrt();

            ValidateISquare(myHeronSqrt);
            ValidateISquare(myStandardSqrt);


            //Computing Sqrt using Heron Method.
            //double resultHeron = myHeronSqrt.ComputeHeronSqrt(number);
            //Console.WriteLine("The Heron result is {0}", resultHeron);
            //Console.ReadLine();

            //Computing Sqrt using Standard Method.
            //double resultStandard = myStandardSqrt.ComputeStandardSqrt(number);
            //Console.WriteLine("The Standard result is {0}", resultStandard);
            //Console.ReadLine();

            //Validation Code
            //Random myrandnum = new Random();
            //int randomValue;
            //for (int i = 0; i < 10000; i++)
            //{
            //    randomValue = myrandnum.Next(0, 100000);

            //    double resultHeron = myHeronSqrt.ComputeHeronSqrt(randomValue);
            //    double resultStandard = myStandardSqrt.ComputeStandardSqrt(randomValue);
            //    double difference = Math.Abs(resultHeron - resultStandard);
            //    if (difference > errorlimit)
            //    {
            //        throw new System.ArgumentException("The difference is greater than the error limit.");
            //    }

            //    Console.WriteLine($"Number: {randomValue}. Heron: {resultHeron}. Standard: {resultStandard}. Diff: {difference}");
            //}

            //Console.ReadLine();
        }

        //This method takes in ISquare to validate that the results are within the error margins.
        public static void ValidateISquare(ISquare isquare)
        {
            Random myrandnum = new Random();
            int randomValue;
            for (int i = 0; i < 10000; i++)
            {
                randomValue = myrandnum.Next(0, 100000);

                double sqrtResult = isquare.Sqrt(randomValue);
                double resultStandard = Math.Sqrt(randomValue);
                double difference = Math.Abs(sqrtResult - resultStandard);
                if (difference > isquare.ErrorMargin)
                {
                    throw new System.ArgumentException("The difference is greater than the error limit.");
                }

                Console.WriteLine($"Number: {randomValue}. ISquare: {sqrtResult}. Standard: {resultStandard}. Diff: {difference}");
            }

            Console.ReadLine();
        } 
    }
}
