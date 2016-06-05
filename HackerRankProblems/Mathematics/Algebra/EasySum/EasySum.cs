using System;

namespace HackerRankProblems.Mathematics.Algebra.EasySum
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/easy-sum
    /// </summary>
    public class Solution
    {
        public static void Main(String[] Args)
        {
            int numTests = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<numTests; i++)
            {
                //need to find the sum from 1 to N for:
                // i mod m
                // the series is therefore:
                // 1%m + 2%m + ... + (m-1)%m + m%m + (m+1)%m + (m+2)%m + ... + (2m-1)%m + ... + N%m
                // since:
                //   1. m%m = 0 
                //   2. (m+x)%m = x
                //   3. (xm-1)%m = (m-1)%m
                // we now have:
                // 1%m + 2%m + ... + (m-1)%m + 1%m + 2%m + ... + (m-1)%m + ... + N%m
                // with a pattern repeating N/m times:
                // N/m*(1%m +2%m + ... + (m-1)%m) + ... + N%m
                // since x%m = x for 1<=x<m:
                // the sum is therefore:
                // N/m*(1 + 2 + ... + (m-1)) + ... + N%m
                // using the finite sum theorem x(x+1)/2
                // N/m * ((m-1)*m/2) + ... + N%m
                // N/m * (m^2-m)/2 + ... + N%m
                // the remaining sum is 1 to N%m since the series is periodic
                // so again using the finite sum theorem x(x+1)/2:
                // N/m * (m^2-m)/2 + (N%m)(N%m + 1)/2
                string[] testLine = Console.ReadLine().Split(' ');
                ulong N = Convert.ToUInt64(testLine[0]);
                ulong m = Convert.ToUInt64(testLine[1]);
                ulong result = N/m * (m * m - m)/2 + (N % m) * (N % m + 1) / 2;
                Console.WriteLine(result.ToString());
            }
        }
    }
}
