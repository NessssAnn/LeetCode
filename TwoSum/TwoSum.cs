using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TwoSum
    {
        public int[] TSum(int[] nums, int target)
        {
            int a = 1;
        int[] answer = new int[2];
        answer[0] = nums[0];
int[] ansi = new int[2];
        ansi[0] = 0;

do
    {
        for (int i = a; i<nums.Length; i++)
         {
            if (target  - answer[0] == nums[i])
            {
                answer[1] = nums[i];
                ansi[1] = i;
                break;
            }
}
if (answer[1] + answer[0] != target)
{
    answer[0] = nums[a];
    ansi[0] = a;
    a++;
}
    } while (answer[0] + answer[1] != target) ;
return ansi;
    }
    }
}
