using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    public class LeetCode_242
    {
        public static bool IsAnagram(string s, string t)
        {
            char[] char_s = s.ToCharArray();
            char[] char_t = t.ToCharArray();

            char[] chat_s_sorted = char_s.OrderBy(c => c).ToArray();
            char[] chat_t_sorted = char_t.OrderBy(c => c).ToArray();

            int flag = 0; //false

            if (char_s.Length == char_t.Length)
            {
                for (int i = 0; i < chat_s_sorted.Length; i++)
                {
                    if (chat_s_sorted[i] == chat_t_sorted[i])
                    {
                        flag = 1;
                    }
                    else
                    {
                        return false;
                    }
                }
                if(flag == 1)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
