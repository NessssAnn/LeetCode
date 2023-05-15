using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IntegerToRoman
    {
        public string ITR(int num)
        {
            Dictionary<int, char> map = new Dictionary<int, char>()
            {
                {1,'I' },
                {5,'V' },
                {10, 'X' },
                {50, 'L' },
                {100, 'C'},
                {500, 'D'},
                {1000, 'M' }
            };
            string result = "";
            int count = 0;
            while (num > 0)
            {
                int find = num % 10;
                int n = find;
                if (find < 4 && find > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        n *= 10;
                    }
                    char t = map[n / find];
                    for (int i = 0; i < find; i++)
                    {
                        result += t;
                    }
                }
                else if (find == 4 || find ==9)
                {
                    find++;
                    n=find;
                    for (int i = 0; i < count; i++)
                    {
                        n *= 10;
                    }
                    char t = map[n];
                    result += t;
                    t = map[n/find];
                    result += t;
                }
                else if (4 < find && find<9)
                {
                    int five = find-5;
                    int fiven = 5;
                    for (int i = 0; i < count; i++)
                    {
                        n *= 10;
                        fiven *= 10;
                    }
                    char t = map[n / find];
                    for (int i = 0; i < five; i++)
                    {
                        result += t;
                    }
                    t = map[fiven];
                    result += t;
                }
                num /= 10;
                count++;
            }
            char[] res = result.ToCharArray();
            Array.Reverse(res);
            result = new string(res);
            return result;
        }
    }
}
