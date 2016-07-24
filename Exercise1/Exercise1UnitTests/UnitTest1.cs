using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise1;

namespace Exercise1UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodStandard()
        {
            StdSqrt myStandardSqrt = new StdSqrt();

            ValidateISquare(myStandardSqrt);
        }

        [TestMethod]
        public void TestMethodHeron()
        {
            MySquare myHeronSqrt = new MySquare(0.0001);

            ValidateISquare(myHeronSqrt);
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
                Assert.IsTrue(difference <= isquare.ErrorMargin, $"The difference was greater than expected for {randomValue}. Expected: {isquare.ErrorMargin}. Actual: {difference}");

                if (difference > isquare.ErrorMargin)
                {
                    throw new System.ArgumentException("The difference is greater than the error limit.");
                }
            }
        }
    }
}
