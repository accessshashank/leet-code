using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question14
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "flowrt", "flower", "flow", "flowht" };
            Console.WriteLine(LongestCommonPrefix(strs));
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            string prefix = strs[0];
            foreach (string str in strs)
            {
                if(str.Length < prefix.Length)
                {
                    prefix = str;
                }
            }

            foreach (var str in strs)
            {
                while(str.Substring(0, prefix.Length) != prefix)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }

            return prefix;
        }
    }
}
