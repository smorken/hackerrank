using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Mathematics.Algebra.EasySum
{
    using HackerRankProblems.Mathematics.Algebra.EasySum;
    [TestClass]
    public class EasySumTest
    {
        [TestMethod]
        public void Test01()
        {
            string input =
@"3
10 5
10 3
5 5";
            string expectedOutput =
@"20
10
10";
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MyTest01()
        {
            string input =
@"4
1 1
2 1
1 2
2 2";
            string expectedOutput =
@"0
0
1
1";
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }

        int EasySum(int N, int m)
        {
            int sum = 0;
            for(int i = 1; i<=N; i++)
            {
                sum += i % m;
            }
            return sum;
        }

        [TestMethod]
        public void MyTest02()
        {
            string input =
@"4
10 11
11 10
17 19
19 17";
            string expectedOutput = String.Format(
@"{0}
{1}
{2}
{3}", EasySum(10,11), EasySum(11,10), EasySum(17,19), EasySum(19,17));
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }
    }
}
