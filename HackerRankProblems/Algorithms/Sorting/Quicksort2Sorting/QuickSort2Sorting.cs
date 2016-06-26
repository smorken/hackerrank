using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Algorithms.Sorting.Quicksort2Sorting
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/quicksort2
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
        /// <summary>
        /// this is needed to solve the problem 
        /// </summary>
        /// <param name="ar">the array to partition</param>
        /// <param name="start">the start index of a subset of the array to partition</param>
        /// <param name="end">the end index of the subset to partition</param>
        /// <returns>the pivot index</returns>
        private static int StablePartition(int[] ar, int start, int end)
        {
            int pivot = ar[start];
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for (int i = start + 1; i <= end; i++)
            {
                if (ar[i] < pivot)
                {
                    left.Add(ar[i]);
                }
                else
                {
                    right.Add(ar[i]);
                }
            }
            int pivotIndex = left.Count + start;
            left.Add(pivot);
           
            int[] subAr = left.Concat(right).ToArray();
            for (int i = start; i <= end; i++)
            {
                ar[i] = subAr[i - start];
            }

            return pivotIndex;
        }

        private static int Partition(int[] ar, int start, int end)
        {
            int pivot = ar[start];
            int partitionStart = start + 1;
            for (int i = start + 1; i <= end; i++)
            {
                if (ar[i] < pivot)
                {
                    Swap(partitionStart, i, ar);
                    partitionStart++;
                }
            }
            Swap(partitionStart - 1, start, ar);

            return partitionStart - 1;
        }
        static void Sort(int[] ar, int start, int end)
        {
            if (start >= end) { return; }
            int p = StablePartition(ar, start, end);
            Sort(ar, start, p-1);
            Sort(ar, p + 1, end);
            string result = String.Join(" ", ar.Skip(start).Take(end - start + 1));
            Console.WriteLine(result);
        }
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = Console.ReadLine()
                .Split().Select(a => Convert.ToInt32(a))
                .ToArray();
            Sort(ar, 0, ar.Length-1);
        }
    }
}
