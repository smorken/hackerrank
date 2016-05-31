using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HackerRankTests
{
    using HackerRankProblems;
    /// <summary>
    /// test class that allows HackerRank solutions to be run directly in a unit test
    /// </summary>
    public class TestCaseLoader
    {
        /// <summary>
        /// trying to simulate the Hackerrank check for output equality
        /// </summary>
        /// <param name="first">the path to the first file to compare</param>
        /// <param name="second">the path to the second file to compare</param>
        /// <returns>true if the 2 files have the same data</returns>
        public static bool CompareOutput(string first, string second)
        {
            using (StreamReader s1 = new StreamReader(first))
            using (StreamReader s2 = new StreamReader(second))
            {

                while (true)
                {
                    string line1 = s1.ReadLine();
                    string line2 = s2.ReadLine();
                    if (line1 == null && line2 == null)
                    {
                        return true;
                    }
                    else
                    {
                        if (line1 == null) { return false; }//check for different file lengths
                        if (line2 == null) { return false; }
                        string[] s1Tokens = line1.Split();
                        string[] s2Tokens = line2.Split();
                        if (s1Tokens.Length != s2Tokens.Length)
                        {
                            return false;
                        }
                        for (int i = 0; i < s1Tokens.Length; i++)
                        {
                            if (s1Tokens[i] != s2Tokens[i])
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }
        public static bool FileTest(string TestInputPath, string ExpectedResultsPath, Action<string[]> method)
        {
            using (TempFile t = new TempFile("temp.txt", null))
            {
                TestCaseLoader.SetUp(TestInputPath, t.Filename);
                method(null);
                TestCaseLoader.TearDown();
                return TestCaseLoader.CompareOutput(ExpectedResultsPath, "temp.txt");
            }
        }
        public static bool TempFileTest(string input, string expectedOutput, Action<string[]> method)
        {
            using (TempFile inputFile = new TempFile("input.txt", input))
            using (TempFile outputFile = new TempFile("output.txt", ""))
            using (TempFile expectedFile = new TempFile("expectedOutput.txt", expectedOutput))
            {
                TestCaseLoader.SetUp(inputFile.Filename, outputFile.Filename);
                method(null);
                TestCaseLoader.TearDown();
                return TestCaseLoader.CompareOutput(expectedFile.Filename, outputFile.Filename);
            }
        }
        public static void SetUp(string InputFile, string OutputFile) {
            Console.In = new StreamReader(InputFile);
            Console.Out = new StreamWriter(OutputFile);
        }

        public static void TearDown()
        {
            if (Console.In != null) { Console.In.Dispose(); }
            if (Console.Out != null) { Console.Out.Dispose(); }
        }
    }
}
