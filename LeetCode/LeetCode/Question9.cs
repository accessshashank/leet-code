using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question9
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(IsPalindrome(x));
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            if (x >= 0 && x <= 9)
                return true;
            int copy = x;
            var stack = new Stack<int>();

            while(x != 0)
            {
                var lastDigit = x % 10;
                stack.Push(lastDigit);
                x = x / 10;
            }

            int counter = 0;
            double num = 0;
            while(stack.Count >= 1)
            {
                num = num + stack.Pop()*Math.Pow(10, counter);
                counter++;
            }

            if (copy == num)
                return true;
            return false;
        }
    }
}
