using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Mathematics.Algebra.SteppingStonesGame
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/stepping-stones-game
    /// </summary>
    public class Solution
    {
        public static void Main(string[] Args)
        {
            // need to check if N is a solution to a sequential sum
            // so is there some value n in:
            // n*(n+1)/2 
            // that results in an integer N
            // 
            // (n^2+n)/2 - N = 0
            // n^2 + n - 2N = 0
            // complete the square:
            // n^2 + n + 1/4 -2N -1/4 = 0
            // (n+1/2)^2 = 1/4 + 2N
            // n + 1/2 = +/- sqrt((1 + 8N)/4)
            // n = (-1 +/- sqrt(1+8N))/2
            // since we are constrained to integer values of n:
            // sqrt(1+8N) must also be an integer

            int numTests = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numTests; i++)
            {
                long N = Convert.ToInt64(Console.ReadLine());
                long sqrtN = (long)Math.Sqrt(1 + 8 * N);
                if (sqrtN * sqrtN == (1 + 8*N))
                {
                    //only need the positive solution
                    long n = (-1 + sqrtN) / 2;
                    
                    Console.WriteLine(String.Format("Go On Bob {0}", n));
                }
                else
                {
                    Console.WriteLine("Better Luck Next Time");
                }

            }


        }
    }
}
