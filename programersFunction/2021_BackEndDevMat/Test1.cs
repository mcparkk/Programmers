using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice._2021_BackEndDevMat
{
    public class Test1
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int maxCount = 0;       // 최대로 맞출 갯수
            int lowCount = 0;       // 최소로 맞출 갯수 
            Dictionary<int, int> resultDic = new Dictionary<int, int>()
            {
                {6,1},
                {5,2},
                {4,3},
                {3,4},
                {2,5},
                {1,6},
                {0,6},
            };

            // 내 로또와 정답 중복값 제거 -> 카운트 -> 갯수로 최대 최소 
            for (int i = 0; i < 6; i++)
            {
                for(int j = 0; j< 6; j++)
                {
                    if(lottos[i] == win_nums[j])
                        lottos[i] = -1;
                }
            }

            foreach(var num in lottos)
            {
                if (num == 0)
                    lowCount++;
                if (num == -1)
                    maxCount++;
            }
            maxCount += lowCount;
            lowCount = maxCount - lowCount;

            int[] answer = new int[] { resultDic[maxCount], resultDic[lowCount] };
            return answer;
        }
    }
}
