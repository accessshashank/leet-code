using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question3
    {
        static void Main(string[] args)
        {
            string s = "pwwkew";
            Console.WriteLine(LengthOfLongestSubstring(s));
        }

        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int i = 0; int j = 0;
            int len = 0;
            HashSet<char> hashSet = new HashSet<char>();
            while(j < s.Length)
            {
                if(hashSet.Contains(s[j]) == false)
                {
                    hashSet.Add(s[j]);
                    j++;
                    len = Math.Max(len, j - i);
                }
                else
                {
                    hashSet.Remove(s[i]);
                    i++;
                }
            }
            return len;
        }
    }
}
