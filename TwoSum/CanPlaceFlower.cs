using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CanPlaceFlower
    {
        public bool CPF(int[] flowerbed, int n)
        {
            bool answer = false;
            int can = 0;
            int now = 0;
            if (flowerbed.Length > 1)
            {
                for (int fut = 1; fut < flowerbed.Length; fut++)
                {
                    if (flowerbed[now] == 0)
                    {
                        if (flowerbed[fut] == 0)
                        {
                            flowerbed[now] = 1;
                            can++;
                            now = fut + 1;
                            fut += 1;
                        }
                        else
                        {
                            now = fut;
                        }
                    }
                    else
                    {
                        now = fut + 1;
                        fut += 1;
                    }
                }
                if (flowerbed[flowerbed.Length - 2] == 0 && flowerbed.Last() == 0)
                {
                    can++;
                    flowerbed[flowerbed.Length - 1] = 1;
                }
            }
            else
            {
                if (flowerbed[0] == 0)
                    can++;
            }
            if (can >= n) { answer = true; }
            return answer;
        }
    }
}
