using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersMain
{
    public class lv1_primeNumber
    {
        public int solution(int n)
        {
            int answer = 0;
            int divisorCount = 0;

            for(int i = 2; i<=n; i++)
            {
                for(int j = 1; j*j <= i; j++)
                {
                    if (i % j == 0)
                        divisorCount++;
                    if (divisorCount > 2)
                        break;
                }
                if (divisorCount < 2)
                    answer++;

                divisorCount = 0;
            }

            return answer;
        }
    }
}
