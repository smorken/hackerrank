using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Mathematics.Fundamentals
{
    using HackerRankProblems.Mathematics.Fundamentals.SummingTheNSeries;
    [TestClass]
    public class SummingTheNSeriesTest
    {
        [TestMethod]
        public void Test01()
        {
            string input =
@"2
2 
1";
            string expectedOutput =
@"4
1";
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test05()
        {
            string input =
@"10
5351871996120528
2248813659738258
2494359640703601
6044763399160734
3271269997212342
4276346434761561
2372239019637533
5624204919070546
9493965694520825
8629828692375133";
            string expectedOutput =
@"578351320
404664464
20752136
999516029
743537718
323730244
174995256
593331567
136582381
305527433";
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MyTest01()
        {
            string input =
@"1
200";
            int expectedSum = 0;
            for(int i = 1; i != 201; i++)
            {
                expectedSum += 2 * i - 1;
            }
            string expectedOutput = expectedSum.ToString();
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MyTest02()
        {
            string input =
@"1
3001";

            string expectedOutput = Math.Pow(3001,2).ToString();
            bool result = TestCaseLoader.TempFileTest(input, expectedOutput, Solution.Main);
            Assert.IsTrue(result);
        }


    }
}
