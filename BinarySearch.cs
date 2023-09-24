using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet
{
    internal class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int mid = 0, min = 0, max = nums.Length - 1;

            while (min <= max)
            {
                mid = (min + max) / 2;

                if (target == nums[mid])
                {
                    return ++mid;
                }
                else if (target < nums[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;

        }
    }
}
