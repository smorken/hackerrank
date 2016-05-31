using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms.GraphTheory.bfsshortreach
{

    using HackerRankProblems.Algorithms.GraphTheory.bfsshortreach;

    [TestClass]
    public class bfsshortreachTest
    {
        [TestMethod]
        public void Test05()
        {
            string TestInputPath = @"Algorithms\GraphTheory\bfsshortreach\input05.txt";
            string ExpectedResultsPath = @"Algorithms\GraphTheory\bfsshortreach\output05.txt";
            Assert.IsTrue(TestCaseLoader.FileTest(TestInputPath, ExpectedResultsPath, Solution.Main));
        }



        [TestMethod]
        public void Test01()
        {
            string input = 
@"2
4 2
1 2
1 3
1
3 1
2 3
2";
            string expectedOutput = 
@"6 6 -1
-1 6";
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Test03()
        {
            string input =
@"1
10 6
3 1
10 1
10 1
3 1
1 8
5 2
3";
            string expectedOutput = @"6 -1 -1 -1 -1 -1 12 -1 12";
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }

    }
}
