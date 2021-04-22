using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question12
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(34));
        }

        public static string IntToRoman(int num)
        {
            var builder = new StringBuilder();
            string[] roman = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            for(int i=0; i< 13; i++)
            {
                while(num - values[i] >=0)
                {
                    num = num - values[i];
                    builder.Append(roman[i]);
                }
            }
            return builder.ToString();
        }
    }
}
