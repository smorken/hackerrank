using System;
using System.Linq;
namespace HackerRankProblems.Algorithms.Sorting.InsertionSortPart1
{
    public class Solution
    {
        static void print(int[] ar)
        {
            Console.WriteLine(String.Join(" ", ar));
        }
        static void insertionSort(int[] ar)
        {

            int last = ar[ar.Length - 1];
            for (int i = ar.Length - 2; i >= 0; i--)
            {
                if (ar[i] > last)
                {

                    ar[i + 1] = ar[i];
                    print(ar);
                    if (i == 0)
                    {
                        ar[0] = last;
                        print(ar);
                    }

                }
                else
                {
                    ar[i + 1] = last;
                    print(ar);
                    break;
                }
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