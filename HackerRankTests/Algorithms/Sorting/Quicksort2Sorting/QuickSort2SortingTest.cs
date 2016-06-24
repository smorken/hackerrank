using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms.Sorting.Quicksort2Sorting
{
    using HackerRankProblems.Algorithms.Sorting.Quicksort2Sorting;
    [TestClass]
    public class QuickSort2SortingTest
    {
        [TestMethod]
        public void Test00()
        {
            string input =
@"7
5 8 1 3 7 9 2";
            string expectedOutput =
@"2 3
1 2 3
7 8 9
1 2 3 5 7 8 9";
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }
    }
}
