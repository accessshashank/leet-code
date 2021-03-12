using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question5
    {
        static void Main(string[] args)
        {
            string s = "ac";
            Console.WriteLine(LongestPalindrome(s));
        }

        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            if (s.Length == 1) return s;

            int startIndex = 0;
            int length = 0;

            for(int i=0; i<s.Length-1;i++)
            {
                 Expand(s, i, i, ref startIndex, ref length);
                 Expand(s, i, i + 1, ref startIndex, ref length);
                
            }
            return s.Substring(startIndex, length);
        }

        public static void Expand(string s, int left, int right, ref int startIndex, ref int length)
        {
            while(left >=0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            if(length < (right - left -1))
            {
                length = right - left - 1;
                startIndex = left + 1;
            }
        }
    }
}
