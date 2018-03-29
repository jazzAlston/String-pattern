using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "aaabbbc";
            char[]testResult = pattern.Distinct().ToArray();
            string result = "";
            string[] input = new string[] { "dog", "dog", "dog", "cat","cat","cat","fish" };
            string[] testString = input.Distinct().ToArray();
           
            Dictionary<string, char> dic = new Dictionary<string, char>();
            if (testString.Length > testResult.Length)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int i = 0; i < testString.Length; i++)
                {
                    if (!dic.ContainsKey(testString[i]))
                    {
                        dic.Add(testString[i], testResult[i]);
                    }
                }

                foreach (var item in input)
                {
                    result += dic[item];
                }
                Console.WriteLine(result == pattern);
            }
        }
    }
}
