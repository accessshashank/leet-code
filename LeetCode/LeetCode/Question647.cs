using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question647
    {
        static void Main(string[] args)
        {
            string s = "abc";
            Console.WriteLine(CountSubstrings(s));
        }

        public static int CountSubstrings(string s)
        {
            int length = s.Length;
            int j; int i;
            int counter = 0;
            bool[,] dp = new bool[length, length];
            for(int gap=0; gap<length; gap++)
            {
                j = gap;
                i = 0;
                while(j < length)
                {
                    if(gap == 0)
                    {
                        dp[i, j] = true;
                    } 
                    else if(gap == 1)
                    {
                        dp[i, j] = s[i] == s[j];
                    }
                    else
                    {
                        dp[i, j] = s[i] == s[j] && dp[i + 1, j - 1] == true;
                    }

                    if (dp[i, j] == true) counter++;

                    i++;
                    j++;

                    
                }


            }

            return counter;
        }
    }
}
