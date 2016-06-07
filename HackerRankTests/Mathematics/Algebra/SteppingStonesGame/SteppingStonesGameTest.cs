using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Mathematics.Algebra.SteppingStonesGame
{
    using HackerRankProblems.Mathematics.Algebra.SteppingStonesGame;
    [TestClass]
    public class SteppingStonesGameTest
    {
        [TestMethod]
        public void Test00()
        {
            string input =
@"1
2";
            string expectedOutput =
@"Better Luck Next Time";

            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test01()
        {
            string input =
@"1
3";
            string expectedOutput =
@"Go On Bob 2";

            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void MyTest01()
        {
            string input =
@"1
21";
            string expectedOutput =
@"Go On Bob 6";

            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MyTest02()
        {
            string input =
@"1
27";
            string expectedOutput =
@"Better Luck Next Time";

            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }
    }
}
