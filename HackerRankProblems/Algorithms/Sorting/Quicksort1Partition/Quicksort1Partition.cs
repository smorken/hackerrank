using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Algorithms.Sorting.Quicksort1Partition
{

    /// <summary>
    /// https://www.hackerrank.com/challenges/quicksort1
    /// </summary>
    public class Solution
    {
        static void Swap(int x1, int x2, ref int[] ar)
        {
            if (x1 == x2) { return; }
            int tmp = ar[x1];
            ar[x1] = ar[x2];
            ar[x2] = tmp;
        }
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = Console.ReadLine()
                .Split().Select(a => Convert.ToInt32(a)).ToArray();
            
            int pivot = ar[0];
            int partitionStart = 1;
            for(int i = 1; i<ar.Length; i++)
            {
                if(ar[i] < pivot)
                {
                    Swap(partitionStart, i, ref ar);
                    partitionStart ++;
                }
            }
            Swap(partitionStart - 1, 0, ref ar);

        }
    }
}
