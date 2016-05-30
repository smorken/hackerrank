using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms.GraphTheory.bfsshortreach
{
    using HackerRankProblems.Algorithms.GraphTheory.bfsshortreach;
    [TestClass]
    public class bfsshortreachTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string TestInputPath = @"Algorithms\GraphTheory\bfsshortreach\input05.txt";
            string ExpectedResultsPath = @"Algorithms\GraphTheory\bfsshortreach\output05.txt";
            TestCaseLoader.SetUp(TestInputPath, "temp.txt");
            Solution.Main(null);
            TestCaseLoader.TearDown();
            TestCaseLoader.FilesAreEqual(new System.IO.FileInfo(ExpectedResultsPath), new System.IO.FileInfo("temp.txt"));
        }
    }
}
