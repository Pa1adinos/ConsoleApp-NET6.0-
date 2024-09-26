using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class indexOfSum
    {
        public static int[] Start(int[] nums, int target)
        {
            int[] array = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        array[0] = i;
                        array[1] = j;
                        return array;
                    }
                }
            }
            return array;
        }
    }
}
