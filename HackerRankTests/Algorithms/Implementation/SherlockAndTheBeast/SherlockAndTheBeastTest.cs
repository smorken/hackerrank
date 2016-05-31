using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms.Implementation.SherlockAndTheBeast
{
    using HackerRankProblems.Algorithms.Implementation.SherlockAndTheBeast;
    [TestClass]
    public class SherlockAndTheBeastTest
    {
        [TestMethod]
        public void Test01()
        {
            string input =
@"4
1
3
5
11";
            string expectedOutput =
@"-1
555
33333
55555533333";
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }
    }
}
