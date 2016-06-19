using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms.Sorting.InsertionSortPart1
{
    using HackerRankProblems.Algorithms.Sorting.InsertionSortPart1;
    [TestClass]
    public class InsertionSortPart1Test
    {
        [TestMethod]
        public void Test01()
        {
            string input =
@"5
2 4 6 8 3";
            string expectedOutput =
@"2 4 6 8 8
2 4 6 6 8
2 4 4 6 8
2 3 4 6 8";
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test02()
        {
            string input =
@"10
2 3 4 5 6 7 8 9 10 1";

            string expectedOutput =
@"2 3 4 5 6 7 8 9 10 10
2 3 4 5 6 7 8 9 9 10
2 3 4 5 6 7 8 8 9 10
2 3 4 5 6 7 7 8 9 10
2 3 4 5 6 6 7 8 9 10
2 3 4 5 5 6 7 8 9 10
2 3 4 4 5 6 7 8 9 10
2 3 3 4 5 6 7 8 9 10
2 2 3 4 5 6 7 8 9 10
1 2 3 4 5 6 7 8 9 10";

            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }
    }
}
