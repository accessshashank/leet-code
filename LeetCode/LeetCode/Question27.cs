using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question27
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            var len = RemoveElement(nums, val);
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            
            for(int j=0; j<=nums.Length-1;j++)
            {
                if(nums[j] != val)
                {
                    
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }

    }
}
