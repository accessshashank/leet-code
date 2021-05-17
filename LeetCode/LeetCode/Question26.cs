using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question26
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 1, 2 };
            int result = RemoveDuplicates(nums);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1) return nums.Length;
            int i = 0;
            int j = 1;
            while(j <= nums.Length - 1)
            {
                if(nums[i] == nums[j])
                {
                    while(nums[i] == nums[j])
                    {
                        if (j == nums.Length - 1) break;
                        j++;
                    }
                    int count = nums[i] == nums[j] ? j : j - 1;
                    for(int k = i+1; k<=count;k++)
                    {
                        nums[k] = int.MinValue;
                    }
                    i = j;
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
            }

            for(int k=0; k<=nums.Length-1;k++)
            {
                if(nums[k] == int.MinValue)
                {
                    int counter = k + 1;
                    
                    while((counter <= nums.Length -1) &&  nums[counter] == int.MinValue)
                    {
                        counter++;
                    }
                    if(counter <= nums.Length - 1)
                    {
                        nums[k] = nums[counter];
                        nums[counter] = int.MinValue;
                    }
                   
                }
            }

            return nums.Where(e => e != int.MinValue).Count();
        }
    }
}
