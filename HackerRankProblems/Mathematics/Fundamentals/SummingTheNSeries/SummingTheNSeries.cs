using System;
using System.Numerics;

namespace HackerRankProblems.Mathematics.Fundamentals.SummingTheNSeries
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/summing-the-n-series
    /// </summary>
    public class Solution
    {
        public static void Main(String[] args)
        {
            //the term n in the series to compute is:
            // n^2 - (n-1)^2
            // = n^2 - (n^2-2n+1)
            // = 2n-1

            // we now have 2 sums (one for the 2n term and one for the -1 term):
            // using the theorem of finite series
            //http://calculus.nipissingu.ca/tutorials/finiteseries.html
            // the sum of 2n-1 from 1 to m  
            // = 2 * m(m + 1)/2 - m
            // = m(m + 1) - m
            // = m^2

            int numTests = Convert.ToInt32(Console.ReadLine());
            
            //see test:
            int mod = (int)Math.Pow(10, 9) + 7;

            for (int test = 0; test < numTests; test++) {
                BigInteger m = BigInteger.Parse(Console.ReadLine());
                BigInteger result = BigInteger.ModPow(m, 2, mod);
                Console.WriteLine(result.ToString());
            }
        }
    }
}
