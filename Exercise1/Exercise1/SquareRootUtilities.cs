using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class SquareRootUtilities
    {
        //A little helper method to check for Positive Numbers.
        public static void CheckForPositive(double number)
        {
            if (number < 1)
            {
                throw new System.ArgumentException("Negative numbers are not allowed");
            }
        }

        //Method to guess the square root of a number.
        //Takes in the number and an error limit.
        public static double ComputeHeronSquareRoot(double number, double errorlimit)
        {
            //Checks for Positive Numbers.
            CheckForPositive(number);
            
            //Our initial guess starts as the number divided by 2.
            double guess = number / 2;

            //If the diff is greater than the error limit then we will need to guess again by...
            //...taking the average of the first guess and the number divided by the previous guess.
            while (Math.Abs(number - (guess * guess)) > errorlimit)
            {
                guess = (guess + (number / guess) ) * .5;
            }

            return guess;
        }
    }
}
