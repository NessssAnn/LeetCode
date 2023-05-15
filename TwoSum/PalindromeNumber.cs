using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            List<int> ListOfInt = new List<int>();
            List<int> ListOfInt2 = new List<int>();
            bool flag = true;
            if (x >= 0)
            {
                while (x > 0)
                {
                    ListOfInt.Add(x % 10);
                    ListOfInt2.Add(x % 10);
                    x /= 10;
                }
                ListOfInt.Reverse();
                for (int i = 0; i < ListOfInt.Count; i++)
                {
                    if (ListOfInt[i] != ListOfInt2[i])
                    {
                        flag = false;
                        break;
                    }
                }
            }
            else { flag = false; }
            return flag;
        }
    }
}
