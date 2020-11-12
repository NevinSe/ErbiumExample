using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErbiumProblemSolvingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemSolvingProblems problemSolvingProblems = new ProblemSolvingProblems();
            //problemSolvingProblems.CompressString("aaabbcccc");
            //string response = problemSolvingProblems.ReverseString("hello");
            bool response = problemSolvingProblems.Palindrome("hello");
            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}
