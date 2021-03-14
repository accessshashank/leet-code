using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question7
    {
        static void Main(string[] args)
        {
            int x = 120;
            Console.WriteLine(Reverse(x));
        }

        public static int Reverse(int x)
        {
            string str = (x < 0) ? (x*-1).ToString() : x.ToString();
            string rev = "";
            var array = str.ToCharArray();
            Array.Reverse(array);
            foreach(var ch in array)
            {
                rev += ch;
            }

            try
            {
                int val = int.Parse(rev);
                var value = x < 0 ? val*-1 :  val;
                return value;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
    }
}
