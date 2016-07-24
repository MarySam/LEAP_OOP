using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class StdSqrt : ISquare
    {
        public double ErrorMargin
        {
            get
            {
                return 4e-10;
            }
        }

        public double Sqrt(double number)
        {
            //Checks for Positive Numbers.
            if (number < 1)
            {
                throw new System.ArgumentException("Negative numbers are not allowed");
            }
            double result;
            result = Math.Sqrt(number);
            return result;
        }
    }
}
