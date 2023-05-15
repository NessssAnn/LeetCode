using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SearchinRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int result = Array.IndexOf(nums, target);
            return result;
        }
        public int SearchGold(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                int l = (end + start) / 2; //middle
                if (nums[l] == target) return l;
                if (nums[start] <= nums[l])
                {
                    if (target >= nums[start] && target <= nums[l])
                    {
                        end = l - 1;
                    }
                    else start = l+1;
                }
                else 
                { 
                    if (nums[l]<=target && nums[end]>=target)
                    {
                        start = l + 1;
                    }
                    else end = l-1;
                }
            }
            return -1;
        }

        public bool SearchSecondPart(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                int l = (end - start) / 2 + start; //middle
                if (nums[l] == target) return true;
                if (nums[start] == nums[l] && nums[end] == nums[l])
                {
                    start++;
                    end--;
                }
                else if (nums[start] <= nums[l])
                {
                    if (target >= nums[start] && target <= nums[l])
                    {
                        end = l - 1;
                    }
                    else start = l + 1;
                }
                else
                {
                    if (nums[l] < target && nums[end] >= target)
                    {
                        start = l + 1;
                    }
                    else end = l - 1;
                }
            }
            return false;
        }
    }
}
