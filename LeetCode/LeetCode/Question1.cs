using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question1
    {
        static void Main(string[] args)
        {
            int[] nums = { 3,3 };
            int target = 6;
            var result = TwoSum(nums, target);
            Console.WriteLine("({0},{1})", result[0], result[1]);
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = { -1, -1 };
            for(int i=0;i<=nums.Length-1;i++)
            {
                for(int j=i+1; j<=nums.Length-1;j++)
                {
                    if(nums[i] +nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }
            return result;
        }
    }
}
