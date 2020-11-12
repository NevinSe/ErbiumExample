using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ErbiumProblemSolvingProblems
{
    class ProblemSolvingProblems
    {
       
        //aaabbcccc
        //3a2b4c
        public void CompressString(string wordToCompress)
        {
            int counter = 1;
            string compressedWord = "";
            for(int i = 0; i < wordToCompress.Length; i++)
            {
                if(i != wordToCompress.Length - 1)
                {
                    if (wordToCompress[i] == wordToCompress[i + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        compressedWord += counter + wordToCompress[i].ToString();
                        counter = 1;
                    }
                }
                else
                {
                    compressedWord += counter + wordToCompress[i].ToString();
                }
               
            }
            Console.WriteLine(compressedWord);
        }
        public string ReverseString(string forwardWord)
        {
            string reversedStr = "";
            for (int i = forwardWord.Length - 1; i >= 0; i--)
            {
                reversedStr += forwardWord[i].ToString();
            }
            return reversedStr;
            //return string.Join("", forwardWord.ToCharArray().Reverse());
        }
        public bool Palindrome(string wordToCheck)
        {
            if (wordToCheck == ReverseString(wordToCheck))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void example()
        {
            Person person = new Person();
        }
    }
}
