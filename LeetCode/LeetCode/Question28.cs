using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question28
    {
        static void Main(string[] args)
        {
            string haystack = "mississippi";
            string needle = "issipi";
            var index = StrStr1(haystack, needle);
        }

        public static int StrStr(string haystack, string needle)
        {
            if (needle == "") return 0;
            if (needle.Length > haystack.Length) return -1;
            int i = 0;
            int j = 0;
            int index = -1;
            bool cont = false;
            int matchCounter = 0;
            while(j <= haystack.Length-1)
            {
                if(needle[i] == haystack[j])
                {
                   
                    i++;
                    
                    matchCounter++;
                    if(cont == false)
                    {
                        cont = true;
                        index = j;
                    }
                    j++;
                    if (matchCounter == needle.Length)
                    {
                        break;
                    }
                }
                else
                {
                    i = 0;
                    j = cont == true ? index+1 : j+1;
                    index = -1;
                    cont = false;
                    matchCounter = 0;
                }
            }
            return (matchCounter == needle.Length) ? index : -1;
        }

        public static int StrStr1(string haystack, string needle)
        {
            int len = haystack.Length - needle.Length;
            for (var i = 0; i <= len; i++)
            {
                int j = 0;
                for (j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] == needle[j]) continue;
                    break;
                }
                if (j == needle.Length) return i;
            }

            return -1;
        }
    }
}
