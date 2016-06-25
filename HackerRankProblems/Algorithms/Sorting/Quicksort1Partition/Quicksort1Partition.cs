using System;
using System.Linq;

namespace HackerRankProblems.Algorithms.Sorting.Quicksort1Partition
{

    /// <summary>
    /// https://www.hackerrank.com/challenges/quicksort1
    /// </summary>
    public class Solution
    {
        static void Swap(int x1, int x2, int[] ar)
        {
            if (x1 == x2) { return; }
            int tmp = ar[x1];
            ar[x1] = ar[x2];
            ar[x2] = tmp;
        }
        private static int[] Partition(int[] ar, int start, int end)
        {
            int pivot = ar[start];
            int partitionStart = start + 1;
            for (int i = start; i < end; i++)
            {
                if (ar[i] < pivot)
                {
                    Swap(partitionStart, i, ar);
                    partitionStart++;
                }
            }
            Swap(partitionStart - 1, 0, ar);
            return ar;
        }
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = Console.ReadLine()
                .Split().Select(a => Convert.ToInt32(a)).ToArray();
            ar = Partition(ar, 0, ar.Length);
            Console.WriteLine(String.Join(" ", ar));
        }


    }
}
