using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Median
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums3 = nums1.Concat(nums2).ToArray();
            Array.Sort(nums3);
            int len = nums3.Length;
            double result = 0;
            if (len % 2 == 0)
            {
                double a = nums3[(len / 2) - 1];
                double b = nums3[len / 2];
                result = (a + b) / 2;
            }
            else
            {
                double c = (nums3[len / 2]);
                result = nums3[(len / 2)];
            }

            return result;
        }
    }
}
