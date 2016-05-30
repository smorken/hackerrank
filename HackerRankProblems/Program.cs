using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    public class Console
    {
        public static StreamWriter Out;
        public static StreamReader In;
        public static string ReadLine()
        {
            return In.ReadLine();
        }
        public static void WriteLine(string s)
        {
            Out.WriteLine(s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (Console.In = new StreamReader(@"D:\HackerRankProblems\HackerRankProblems\Algorithms\GraphTheory\bfsshortreach\input05.txt"))
            using (Console.Out = new StreamWriter("testOutput.txt"))
            {
                Algorithms.GraphTheory.bfsshortreach.Solution.Main(null);
            }
            //HackerRankProblems.Algorithms.GraphTheory.BreadthFirstSearch.Bfsshortreach.Solution s = new HackerRankProblems.Algorithms.GraphTheory.BreadthFirstSearch.Bfsshortreach.Solution();
            

        }
    }

}
