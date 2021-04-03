using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice.Meister
{
    public class GameMap
    {
        int _count = 0;
        int[][,] searchingIndex = new int[8][,]
        {
            new int[,] {{ -1, -1 }},
            new int[,] {{-1, 0}},
            new int[,] {{-1, 1}},
            new int[,] {{0, -1}},
            new int[,] {{0, 1}},
            new int[,] {{1, -1}},
            new int[,] {{1, 0}},
            new int[,] {{1, 1}}
        };

        public int solution(int[,] maps)
        {
            int answer = 0;

            FineRoad(maps, searchingIndex[0]);

            // 재귀함수 완전탐색 => if(index == m,n) => return n 
            // 효율성을 생각해서... if(갈 수 있는 길이 없는 경우) return -1
            // 

            // 지나온길을 다시 안가도록 처리

            // 지나온 길이 아닌 주변 인덱스 탐색 -> -1,-1/-1,0/-1,+1/0,-1/0,+1/+1,-1/+1,0/+1,+1/ 의 인덱스 탐색 


            return answer;
        }

        private void FineRoad(int[,] maps, int[,] nextIndex)
        {
            int x = nextIndex[0,0];
            int y = nextIndex[0, 1];
        }
    }
}
