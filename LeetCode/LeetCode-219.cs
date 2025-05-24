using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode_219
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            List<int> set = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                set.Add(nums[i]);

                if(set.Count > k) 
                {
                    set.Remove(nums[i - k]);
                }
            }
            return false;
        }
    }
}
