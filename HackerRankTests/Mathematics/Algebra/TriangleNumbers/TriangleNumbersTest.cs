using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Mathematics.Algebra.TriangleNumbers
{
    using HackerRankProblems.Mathematics.Algebra.TriangleNumbers;
    [TestClass]
    public class TriangleNumbersTest
    {
        [TestMethod]
        public void Test00()
        {
            string input =
@"2
3
4";
            string expectedOutput =
@"2
3";

            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test04()
        {
            string TestInputPath = @"Mathematics\Algebra\TriangleNumbers\input04.txt";
            string ExpectedResultsPath = @"Mathematics\Algebra\TriangleNumbers\output04.txt";
            Assert.IsTrue(TestCaseLoader.FileTest(TestInputPath, ExpectedResultsPath, Solution.Main));
        }

    }
}
