using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question8
    {
        static void Main(string[] args)
        {
            string s = "words and 987";
            Console.WriteLine(MyAtoi(s));
        }

        public static int MyAtoi(string str)
        {
            string result = "";
            var sign = 1;
            str = str.TrimStart().TrimEnd();
            if (string.IsNullOrEmpty(str)) return 0;
            int index = 0;
            if (str[0] == '+' || str[0] == '-')
            {
                sign = str[0] == '+' ? 1 : -1;
                index++;
            }
            while (index < str.Length)
            {
                if (char.IsNumber(str[index]))
                {
                    result += str[index];
                }
                else
                {
                    break;
                }
                index++;
            }

            try
            {
                if (result == "") return 0;

                var val = int.Parse(result);
                return sign * val;
            }
            catch(Exception ex)
            {
                if (sign == 1)
                    return int.MaxValue;
                else
                    return int.MinValue;
            }
        }
    }
}
