using System;

namespace ApproximationAsin
{
    public static class FastMath
    {
        // This function returns the sine angle. With in -PI/4 to PI/4 the maximum error is 0.02 radians.
        // Further, the error begins to grow in proportion to the increase in the quotient in the second term of the equation.

        /// <summary>
        /// Returns the angle whose sine is the specified number.
        /// </summary>
        public static double Asin(double sin)
        {
            return sin > 0 ? sin * (1 - sin / 3 + sin / 2) : sin * (1 - sin / -3 + sin / -2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.WriteLine(FastMath.Asin(Convert.ToDouble(Console.ReadLine())));
            }
        }
    }
}
