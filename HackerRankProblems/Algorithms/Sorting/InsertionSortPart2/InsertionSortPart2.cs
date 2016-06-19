using System;
using System.Linq;

namespace HackerRankProblems.Algorithms.Sorting.InsertionSortPart2
{
    public class Solution
    {
        static void print(int[] ar)
        {
            Console.WriteLine(String.Join(" ", ar));
        }
        static void insertionSort(int[] ar)
        {
            for(int i = 0; i<ar.Length-1; i++)
            {
                int n = ar[i];
                int m = ar[i + 1];
                if(m < n)
                {
                    int j;
                    for (j = i; j>=0; j--)
                    {
                        if(ar[j+1] > ar[j]) { break; }
                        int tmp = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = tmp;
                    }
                }
                print(ar);
            }
            
        }
        public static void Main(String[] args)
        {

            int _ar_size;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = Console.ReadLine().Split(' ').Select(a => Convert.ToInt32(a)).ToArray();
            insertionSort(_ar);
        }
    }
}
