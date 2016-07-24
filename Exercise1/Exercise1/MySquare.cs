using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class MySquare:ISquare
    {
        //constructor
        public MySquare(double limit)
        {
            this.ErrorMargin = limit;
        }
        public double ErrorMargin { get; set; }

        //Method to guess the square root of a number.
        //Takes in the number and an error limit.
        public double Sqrt(double number)
        {
            //Checks for Positive Numbers.
            if (number < 1)
            {
                throw new System.ArgumentException("Negative numbers are not allowed");
            }

            //Our initial guess starts as the number divided by 2.
            double guess = number / 2;

            //If the diff is greater than the error limit then we will need to guess again by...
            //...taking the average of the first guess and the number divided by the previous guess.
            while (Math.Abs(number - (guess * guess)) > this.ErrorMargin)
            {
                guess = (guess + (number / guess)) * .5;
            }

            return guess;
        }
    }
}


