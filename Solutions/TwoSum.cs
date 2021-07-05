using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Solutions
{
    class TwoSum
    {
        public int[] getTwoSum(int[] nums, int target)
        {
            int[] twoSumArray = new int[2];
            int incrementer = 0;
            foreach(int num in nums)
            {
                twoSumArray[0] = incrementer;
                int complement = target - num;
                for(int i = 0; i < nums.Length; i++)
                {
                    if (incrementer != i)
                    {
                        twoSumArray[1] = i;

                        if (nums[i] == complement)
                        {
                            return twoSumArray;
                        }
                    }
                }
                incrementer++;
            }
            return twoSumArray;
        }
    }
}
