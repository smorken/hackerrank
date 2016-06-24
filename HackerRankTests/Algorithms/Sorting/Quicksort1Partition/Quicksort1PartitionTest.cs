using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms.Sorting.Quicksort1Partition
{
    using HackerRankProblems.Algorithms.Sorting.Quicksort1Partition;
    using System.Collections.Generic;

    [TestClass]
    public class Quicksort1PartitionTest
    {
        void CheckResult(string input, string result)
        {
            
            int[] i = input.Split(' ').Select(a => Convert.ToInt32(a)).ToArray();
            int pivotValue = i[0];
            int[] r = result.Split(' ').Select(a => Convert.ToInt32(a)).ToArray();
            var smaller = i.Where(a => a < pivotValue);
            var larger = i.Where(a => a > pivotValue);
            bool smallerEqual = new HashSet<int>(smaller).SetEquals(r.Where(a => a < pivotValue));
            bool largerEqual = new HashSet<int>(larger).SetEquals(r.Where(a => a > pivotValue));
            bool pivotEqual = pivotValue == r[smaller.Count()];
            Assert.IsTrue(smallerEqual && largerEqual && pivotEqual);
        }
        [TestMethod]
        public void Test00()
        {
            string input =
@"5
4 5 3 7 2";

            string inputLine2 = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)[1];

            using (TempFile inputFile = new TempFile("input.txt", input))
            using (TempFile outputFile = new TempFile("output.txt", ""))
            {
                TestCaseLoader.SetUp("input.txt", "output.txt");
                Solution.Main(null);
                TestCaseLoader.TearDown();
                CheckResult(inputLine2, TestCaseLoader.GetOutput()[0]);
            }
        }


                [TestMethod]
        public void Test03()
        {
            string input =
@"20
45 25 46 48 28 6 13 5 36 44 7 4 11 30 24 34 15 31 38 49";

            string inputLine2 = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)[1];

            using (TempFile inputFile = new TempFile("input.txt", input))
            using (TempFile outputFile = new TempFile("output.txt", ""))
            {
                TestCaseLoader.SetUp("input.txt", "output.txt");
                Solution.Main(null);
                TestCaseLoader.TearDown();
                CheckResult(inputLine2, TestCaseLoader.GetOutput()[0]);
            }
        }
        [TestMethod]
        public void Test04()
        {
            string input =
@"50
-13 68 -43 -71 -39 -10 40 -49 -19 -3 -70 -62 -76 -94 -73 64 72 -5 88 2 -63 92 -40 16 49 47 -86 -51 -9 -14 96 74 -22 -34 38 -12 6 63 19 -69 14 -90 -27 76 54 57 -87 -91 43 -92";

            string inputLine2 = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)[1];

            using (TempFile inputFile = new TempFile("input.txt", input))
            using (TempFile outputFile = new TempFile("output.txt", ""))
            {
                TestCaseLoader.SetUp("input.txt", "output.txt");
                Solution.Main(null);
                TestCaseLoader.TearDown();
                CheckResult(inputLine2, TestCaseLoader.GetOutput()[0]);
            }
        }
    }
}
