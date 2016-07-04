using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Mathematics.Algebra.TriangleNumbers
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/triangle-numbers
    /// </summary>
    public class Solution
    {
        // 0  0  0  0  1  0  0  0  0
        // 0  0  0  1  1  1  0  0  0
        // 0  0  1  2  3  2  1  0  0
        // 0  1  3  6  7  6  3  1  0
        // 1  4  10 16 19 16 10 4  1

        //problem summary: 
        // given the above triangle pattern where:
        // the center column of the first row is 1 and each value for every
        // subsequent row is:
        // value(row,col) = value(row-1)(col-1) + value(row-1)(col) + value(row-1)(col+1)
        // 
        // find the 1-based column number for a give row N for the first 
        // element in N that is an even number

        // Definitions:
        // D1 = the first diagonal: starts at the centre of row 1 and ends at the left most position of row n
        // D2 = the second diagonal: starts at the centre of row 2 and ends at the 2nd position of row n 
        // D3 = the third diagonal: starts at the centre of row 3 and ends at the 3rd position of row n
        // D4 = the fouth diagonal: starts at the centre of row 4 and ends at the 4th position of row n

        // Observations:
        // D1(n) = 1
        // D2(n) = n-1
        // D3(n) = 0,1,3,6,10,15,21,... this is the counting series n(n+1)/2 so
        // shift n by 1:
        // D3(n) = (n-1)n/2
        // D4(n) = 0,0,2,7,16,30,50,... this is series https://oeis.org/A005581 (n-1)*n*(n+4)/6
        // shifting n by 1:
        // D4(n) = (n-1)(n-2)(n+3)/6

        //finding the first even value:
        // n=1, n=2 is always odd
        // D1(n): is never even, so index <> 1
        // D2(n): is even if n is odd because an odd number minus 1 is even, 
        //        meaning if n = 3,5,7,... then index = 2
        // D3(n): is even if n/2 mod 2 = 0 or if (n-1)/2 mod 2, but since all odd 
        //        values of n are covered by D2 then index = 3 if n/2 mod 2 = 0
        //        so: index = 3 if n mod 4 = 0 
        // D4(n): since we know that 
        //        1. all odd values of n are index 1, 
        //        2. all values of n where n mod 4 = 0 are index 2 numbers, 
        //        the remaining values of n needed are: 6,10,14,...
        //        still need to prove this.. not sure how yet..
        public static void Main(String[] Args)
        {
            int numTests = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<numTests; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int answer = -1;
                if (n <= 2)
                {
                    answer = -1;
                }
                else if(n % 2 == 1)
                {
                    answer = 2;
                }
                else if(n % 4 == 0)
                {
                    answer = 3;
                }
                else
                {
                    answer = 4;
                }
                Console.WriteLine(answer.ToString());
            }
        }
    }
}
