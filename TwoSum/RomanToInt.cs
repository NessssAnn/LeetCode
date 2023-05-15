using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RomanToInt
    {
        public int RTI(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100},
                {'D',500},
                {'M',1000 }
            };
            char[] num = s.ToCharArray();
            int now = 0;
            int fut = 1;
            int result = 0;
            while (now < num.Length)
            {
                int first = map[num[now]];
                if (fut < num.Length)
                {
                    int second = map[num[fut]];
                    if (first < second)
                    {
                        result += second - first;
                        now = fut + 1;
                        fut += 2;
                    }
                    else
                    {
                        result += first;
                        now++;
                        fut++;
                    }
                }
                else
                {
                    result += first;
                    now++;
                }
            }
            return result;
        }
    }
}
