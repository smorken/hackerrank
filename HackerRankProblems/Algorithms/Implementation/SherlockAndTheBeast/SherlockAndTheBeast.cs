using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRankProblems.Algorithms.Implementation.SherlockAndTheBeast
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/sherlock-and-the-beast
    /// </summary>
    public class Solution
    {

        static string BuildString(int fives, int threes)
        {
            return String.Join("", new[]{
                String.Join("", Enumerable.Range(0,fives).Select(a=>"5")),
                String.Join("", Enumerable.Range(0,threes).Select(a=>"3")),
             });
        }

        static string Compute(int n)
        {
            int x = n;
            // find the largest portion of n: x
            // such that is x mod 3 equals 0 
            // and (n - x) mod 5 equals 0 
            while (x >= 0)
            {
                if ((x % 3) == 0 && ((n - x) % 5) == 0)
                {
                    return BuildString(x, n - x);
                }
                x--;
            }
            return "-1";
        }
        public static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine(Compute(n));
            }
        }
    }
}
