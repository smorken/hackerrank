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

        [TestMethod]
        public void Test01()
        {
            string input =
@"9
9 8 6 7 3 5 4 1 2";
            string expectedOutput =
@"1 2
4 5
1 2 3 4 5
1 2 3 4 5 6 7
1 2 3 4 5 6 7 8
1 2 3 4 5 6 7 8 9";
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test02()
        {
            string TestInputPath = @"Algorithms\Sorting\Quicksort2Sorting\input02.txt";
            string ExpectedResultsPath = @"Algorithms\Sorting\Quicksort2Sorting\output02.txt";
            Assert.IsTrue(TestCaseLoader.FileTest(TestInputPath, ExpectedResultsPath, Solution.Main));
        }
    }
}
