using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Code
{
    public class TwoNumbersSUM
    {
        public static int[] nums = { 2, 0, 11, 15, 7 };
        public static  int target = 9;
        public static int[] Implementation_1() 
        {
            int n = nums.Length;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[2] { i, j };
                        }
                    }
                }
            }
            catch (Exception e) 
            {
            }
            return new int[0];
        }
    }
}
