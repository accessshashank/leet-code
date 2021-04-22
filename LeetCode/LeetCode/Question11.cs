using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question11
    {
        static void Main(string[] args)
        {
            var input = new int[] { 1, 2, 1 };
            Console.WriteLine(MaxArea(input));
        }

        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0; int right = height.Length - 1;
            while(left < right)
            {
                int min = Math.Min(height[left], height[right]);
                int area = min * (right - left);
                if (area > maxArea)
                {
                    maxArea = area;
                }

                if(height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
    }
}
