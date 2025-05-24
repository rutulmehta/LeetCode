using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode_217
    {
        public static bool main()
        {
            int[] numbers = { 1, 2, 4, 1, 9, 3, 6, 7 };
            HashSet<int> set = new HashSet<int>(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (set.Contains(numbers[i]))
                {
                    return true;
                }
                set.Add(numbers[i]);
            }
            return false;
        }
    }
}
