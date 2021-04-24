using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question13
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }

        public static int RomanToInt(string s)
        {
            var dict = new Dictionary<string, int>();
            dict.Add("M",1000);
            dict.Add("CM",900);
            dict.Add("D",500);
            dict.Add("CD",400);
            dict.Add("C",100);
            dict.Add("XC",90);
            dict.Add("L",50);
            dict.Add("XL",40);
            dict.Add("X",10);
            dict.Add("IX",9);
            dict.Add("V",5);
            dict.Add("IV",4);
            dict.Add("I",1);

            int result = 0;
            int i = 0;
            string str = "";
            while (i <= s.Length - 1)
            {
                if(i == s.Length - 1)
                {
                    str = s.Substring(i, 1);
                    result = result + dict[str];
                    return result;
                }
                str = s.Substring(i, 2);
                if(dict.ContainsKey(str))
                {
                    result = result + dict[str];
                    i += 2;
                }
                else
                {
                    str = s.Substring(i, 1);
                    result = result + dict[str];
                    i += 1;
                }
            }

            return result;
        }
    }
}
