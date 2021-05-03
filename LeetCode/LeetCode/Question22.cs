using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question22
    {
        static void Main(string[] args)
        {
            int n = 3;
            var strings = GenerateParenthesis(n);
        }

        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> strings = new List<string>();
            Generate("(", 1, 0, strings, n);
            return strings;
        }

        private static void Generate(string current, int open, int closed, List<string> strings, int n)
        {
            if(current.Length == 2*n)
            {
                strings.Add(current);
                return;
            }
            if (open < n) Generate(current + "(", open + 1, closed, strings, n);
            if (closed < open) Generate(current + ")", open, closed + 1, strings, n);
        }
    }
}
