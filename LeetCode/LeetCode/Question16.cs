using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question16
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 0 };
            int target = -100;
            Console.WriteLine(ThreeSumClosest(nums, target));
        }

        public static int ThreeSumClosest(int[] nums, int target)
        {
            int returnVal = 0;
            var distance = int.MaxValue;
            var numSorted = nums.OrderBy(x => x).ToArray();
            
            for(int i=0; i<numSorted.Length;i++)
            {
                int left = i + 1;
                int right = numSorted.Length - 1;
                while(left < right)
                {
                    var sum = numSorted[i] + numSorted[left] + numSorted[right];
                    if (sum == target)
                        return sum;

                    var diff = Math.Abs(sum - target);
                    if(diff < distance)
                    {
                        distance = diff;
                        returnVal = sum;
                    }

                    if (sum < target)
                        left++;
                    else
                        right--;
                }
            }

            return returnVal;
        }
    }
}
