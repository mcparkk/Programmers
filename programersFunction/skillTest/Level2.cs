using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersMain
{
    public class Level2
    {
        public int[] solution(int brown, int yellow)
        {
            int[] answer = new int[2];

            for (int j = 1; j <= yellow; j++)
            {
                if (yellow % j == 0)
                {
                    int yellowWidth = j;
                    int yellowHeight = yellow / j;

                    int brownWidth = yellowWidth + 2;
                    int brownHeight = yellowHeight + 2;

                    int brownArea = brownWidth * brownHeight;

                    if (brownArea - yellow == brown)
                    {
                        answer[0] = brownWidth;
                        answer[1] = brownHeight;
                    }
                }
            }
            return answer;
        }
    }
}
