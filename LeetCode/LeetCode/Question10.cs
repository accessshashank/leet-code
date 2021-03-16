using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question10
    {
        static void Main(string[] args)
        {
            string s = "aaa"; string p = "ab*a*c*a";
            Console.WriteLine(IsMatch(s, p));
        }

        public static bool IsMatch(string s, string p)
        {
            int patternCounter = p.Length - 1;
            int stringCounter = s.Length - 1;
            bool match = false;
            while(patternCounter >=0)
            {
                char ch = p[patternCounter];
                if(ch == '.')
                {
                    patternCounter--;
                    stringCounter--;
                }
                else if(ch == '*')
                {
                    patternCounter--;
                    char previous = p[patternCounter];
                    if(previous == '.')
                    {
                        match = true;
                        break;
                    }
                    else
                    {
                        while(stringCounter >= 0 && s[stringCounter] == previous)
                        {
                            stringCounter--;
                        }
                        patternCounter--;
                    }
                }
                else if(stringCounter >= 0 && p[patternCounter] == s[stringCounter])
                {
                    patternCounter--;
                    stringCounter--;
                }
                else
                {
                    match = false;
                    break;
                }
            }

            if (patternCounter ==  stringCounter)
                match = true;

            return match;
        }
    }
}
