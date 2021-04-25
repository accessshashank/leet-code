using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question20
    {
        static void Main(string[] args)
        {
            string s = "[";
            Console.WriteLine(IsValid(s));
        }

        public static bool IsValid(string s)
        {
            bool isValid = true;
            var stack = new Stack<char>();
            int counter = 0;
            while(counter <= s.Length - 1)
            {
                char ch = s[counter];
                if(ch == '[' || ch == '{' || ch == '(')
                {
                    stack.Push(ch);
                }
                if(ch == ']' || ch == '}' || ch == ')')
                {
                    if(stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }
                    char pop = stack.Pop();
                    if(ch == ']' && pop != '[')
                    {
                        isValid = false;
                        break;
                    }
                    else if (ch == '}' && pop != '{')
                    {
                        isValid = false;
                        break;
                    }
                    else if (ch == ')' && pop != '(')
                    {
                        isValid = false;
                        break;
                    }
                }
                counter++;
            }

            if (isValid == false) return false;

            if (stack.Count == 0)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
