using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp
{
    public static class LoopTypes
    {

        internal static int HighestForEachLoop(List<int> nums) 
        {
            int highest = nums[0];

            foreach (var i in nums) {

                if (i > highest) {
                    highest = i;
                }

            }
            return highest;
        }

        internal static int HighestForLoop(List<int> nums)
        {
            int highest = nums[0];

            for (var i = 0; i < nums.Count; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
            }

            return highest;
        }

        internal static int HighestWhileLoop(List<int> nums)
        {

            int max = 0;
            int highest = nums[0];

            while (max <= nums.Count) {

                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] > highest)
                    {
                        highest = nums[i];
                    }
                }
                
                max++;

            }
            return highest;
        }

        internal static int HighestDoWhileLoop(List<int> nums)
        {

            int highest = nums[0];
            int i = 0;

            do
            {
                if (nums[i] > highest)
                {

                    highest = nums[i];
                }
                i++;
            } 

            while (i < nums.Count);
            return highest;
        }


    }
}
