using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms.Sorting.InsertionSortPart2
{
    using HackerRankProblems.Algorithms.Sorting.InsertionSortPart2;
    [TestClass]
    public class InsertionSortPart2Test
    {
        [TestMethod]
        public void Test00()
        {
            string input =
@"6
1 4 3 5 6 2";
            string expectedOutput =
@"1 4 3 5 6 2
1 3 4 5 6 2
1 3 4 5 6 2
1 3 4 5 6 2
1 2 3 4 5 6";
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
@"8 9 6 7 3 5 4 1 2
6 8 9 7 3 5 4 1 2
6 7 8 9 3 5 4 1 2
3 6 7 8 9 5 4 1 2
3 5 6 7 8 9 4 1 2
3 4 5 6 7 8 9 1 2
1 3 4 5 6 7 8 9 2
1 2 3 4 5 6 7 8 9";

            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }
    }
}
