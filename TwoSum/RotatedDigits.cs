using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RotatedDigits
    {
        public int RD(int n)
        {
            int k = 0;
            for (int i=1; i<=n; i++)
            {
                if (find(i) > 0) k++;
            }
            return k;
        }

        public int find(int num)
        {
            int k = 0;
            while (num > 0)
            {
                int ost = num % 10;
                if (ost == 2 || ost == 5 || ost == 6 || ost == 9) k++;
                else if (ost == 3 || ost == 4 || ost == 7) return 0;
                num /= 10;
            }
            return k;
        }
    }
}
