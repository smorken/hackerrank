using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HackerRankTests
{
    using HackerRankProblems;
    public class TestCaseLoader
    {

        /// <summary>
        /// borrowed from here: 
        /// http://stackoverflow.com/questions/1358510/how-to-compare-2-files-fast-using-net
        /// </summary>
        /// <param name="first">FileInfo for the first file to compare</param>
        /// <param name="second">FileInfo for the second file to compare</param>
        /// <returns>true if files are binary equal otherwise false</returns>
        public static bool FilesAreEqual(FileInfo first, FileInfo second)
        {
            const int BYTES_TO_READ = sizeof(Int64);
            if (first.Length != second.Length)
                return false;

            int iterations = (int)Math.Ceiling((double)first.Length / BYTES_TO_READ);

            using (FileStream fs1 = first.OpenRead())
            using (FileStream fs2 = second.OpenRead())
            {
                byte[] one = new byte[BYTES_TO_READ];
                byte[] two = new byte[BYTES_TO_READ];

                for (int i = 0; i < iterations; i++)
                {
                    fs1.Read(one, 0, BYTES_TO_READ);
                    fs2.Read(two, 0, BYTES_TO_READ);

                    if (BitConverter.ToInt64(one, 0) != BitConverter.ToInt64(two, 0))
                        return false;
                }
            }

            return true;
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
