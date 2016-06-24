using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms.Sorting.Quicksort1Partition
{
    using HackerRankProblems.Algorithms.Sorting.Quicksort1Partition;
    [TestClass]
    public class Quicksort1PartitionTest
    {
        [TestMethod]
        public void Test00()
        {
            string input =
@"5
4 5 3 7 2";
            string expectedOutput =
@"3 2 4 5 7";
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }
    }
}
