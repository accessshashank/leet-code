using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question4
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 2 };
            var nums2 = new int[] {  };
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int totalLength = nums1.Length + nums2.Length;
            var mergedArray = new int[totalLength];
            int i = 0;
            int j = 0;
            int k = 0;
            while(i < nums1.Length && j < nums2.Length)
            {
                if(nums1[i] < nums2[j])
                {
                    mergedArray[k++] = nums1[i++];
                }
                else
                {
                    mergedArray[k++] = nums2[j++];
                }
            }

            if(i >= nums1.Length)
            {
                for(;j < nums2.Length; j++)
                {
                    mergedArray[k++] = nums2[j];
                }
            }

            if(j >= nums2.Length)
            {
                for(;i < nums1.Length; i++)
                {
                    mergedArray[k++] = nums1[i];
                }
            }

            if(totalLength%2 != 0)
            {
                var index = Math.Ceiling(Convert.ToDecimal(totalLength) / 2);
                return Convert.ToDouble(mergedArray[Convert.ToInt32(index-1)]);
            }
            else
            {
                var index = totalLength / 2;
                return (Convert.ToDouble(mergedArray[Convert.ToInt32(index - 1)]) + Convert.ToDouble(mergedArray[Convert.ToInt32(index)]))/2;
            }

        }
    }
}
