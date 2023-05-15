using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RemoveDuplicatesfromSortedArray
    {
        public int RDupl(int[] nums)
        {
            int past = 1;
                for (int now = 1; now<nums.Length; now++)
            {
                if (nums[now] != nums[past - 1])
                {
                    nums[past] = nums[now];
                    past++;
                }
                
            }
            return past;
        }

        public int RemoveDupl(int[] nums) //part 2
        {
            int p = 0;
            int past = 1;
            for (int now = 1; now < nums.Length; now++)
            {
                if (nums[now] == nums[past - 1]) { p++; }
                else if (nums[now] != nums[past - 1]) { p = 0; }
                if (p<=1)
                {
                    nums[past++] = nums[now];
                    nums[now] = nums[past - 1];
                }
            }
            return past;
        }
    }
}
